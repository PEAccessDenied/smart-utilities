using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.CloudinaryFile;
using Developmenthub.SmartMetering.GasPlants;
using Developmenthub.SmartMetering.PowerPlants;
using Developmenthub.SmartMetering.Reserviors;
using Developmenthub.SmartMetering.Suppliers.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers
{
    public class SupplierAppService : ApplicationService,ISupplierAppService
    {
        private readonly IRepository<Supplier, Guid> _supplierRepository;
        private readonly IRepository<Address, Guid> _addressRepository;
        private readonly IRepository<BranchAddress, Guid> _branchRepository;
        private readonly ISupplierManager _supplierManager;
        private readonly IOptions<CloudinarySettings> _cloudinaryConfig;
        private readonly Cloudinary _cloudinary;

        public SupplierAppService(
            IRepository<Supplier, Guid> supplierRepository,
            IRepository<Address, Guid> addressRepository,
            IRepository<BranchAddress, Guid> branchRepository,
            ISupplierManager supplierManager,
            IOptions<CloudinarySettings> cloudinaryConfig)
        {
            _supplierRepository = supplierRepository;
            _addressRepository = addressRepository;
            _branchRepository = branchRepository;
            _supplierManager = supplierManager;

            _cloudinaryConfig = cloudinaryConfig;

            Account acc = new Account(
                _cloudinaryConfig.Value.CloudName,
                _cloudinaryConfig.Value.ApiKey,
                _cloudinaryConfig.Value.ApiSecret
            );

            _cloudinary = new Cloudinary(acc);
        }

        public async Task<SupplierDetailDto> CreateAsync(CreateSupplierInput input)
        {
            var supplier = new Supplier
            {
                CompanyEmailAddress = input.CompanyEmailAddress,
                ServiceOffered = input.ServiceOffered,
                CompanyName = input.CompanyName,
                RegNumber =input.RegNumber,
                Telephone = input.Telephone
            };
            return ObjectMapper.Map<SupplierDetailDto>(await _supplierRepository.InsertAsync(supplier));
        }
        public async Task<ListResultDto<SupplierListDto>> GetAllAsync()
        {
            var results = await _supplierRepository.GetAll()
                //.Include(s => s.Wards)
                .Include(x => x.Resources)
                //.ThenInclude(x => x.SupplierZoneResources)
                //.ThenInclude(x => x.Zone)
                .Include(x => x.PowerPlants)
                //.Include(x => x.GasPlants)
                .Include(a => a.Address)
                .Include(b => b.BranchAddress)
                .ToListAsync();
            return new ListResultDto<SupplierListDto>(ObjectMapper.Map<List<SupplierListDto>>(results));
        }

        public async Task<SupplierDetailDto> GetByIdAsync(Guid Id)
        {
            //Query needs to be updated to also retrieve other properties related to supplier, according to the dto
            var results = await _supplierRepository.GetAll()
                //.Include(s => s.Wards)
                .Include(x => x.Resources)
                .ThenInclude(x => x.SupplierZoneResources)
                .ThenInclude(x => x.Zone)
                .ThenInclude(w => w.Wards)
                .Include(x => x.PowerPlants)
                //.Include(x => x.GasPlants)
                .Include(a => a.Address)
                .Include(b => b.BranchAddress)
                .FirstOrDefaultAsync(s => s.Id == Id);
            return ObjectMapper.Map<SupplierDetailDto>(results);
        }

        public async Task<SupplierListDto> UpdateAsync(UpdateSupplierDto input)
        {
            var supplier = await _supplierRepository.FirstOrDefaultAsync(input.Id);

            var address = new Address
            {
                Line1 = input.Address.Line1,
                Line2 = input.Address.Line2,
                City = input.Address.City,
                Province = input.Address.Province,
                PostalCode = input.Address.PostalCode,
            };
            Guid? addressId = await _addressRepository.InsertAndGetIdAsync(address);
            await CurrentUnitOfWork.SaveChangesAsync();

            var branchAddress = new BranchAddress
            {
                Line1 = input.Address.Line1,
                Line2 = input.Address.Line2,
                City = input.Address.City,
                Province = input.Address.Province,
                PostalCode = input.Address.PostalCode,
            };
            Guid? branchId = await _branchRepository.InsertAndGetIdAsync(branchAddress);
            await CurrentUnitOfWork.SaveChangesAsync();

            var results = new SupplierListDto();

            if (supplier != null)
            {
                var files = input.CompanyFiles;
                foreach(var file in files)
                {
                    var uploadResult = new RawUploadResult();
                    if (file != null)
                    {
                        if (file.File.Length > 0)
                        {
                            using (var stream = new MemoryStream(file.File))
                            {
                                var uploadParams = new RawUploadParams()
                                {
                                    File = new FileDescription(file.FileName, stream),
                                };
                                uploadResult = _cloudinary.Upload(uploadParams);
                            }
                        }
                        //if (file.Type == "CompanyRegUrl")
                        //{
                        //    supplier.CompanyRegUrl = uploadResult.Uri.ToString();
                        //    supplier.CompanyRegPublicId = uploadResult.PublicId;
                        //}
                        //else if(file.Type == "CompanyProfileUrl")
                        //{
                        //    supplier.CompanyProfileUrl = uploadResult.Uri.ToString();
                        //    supplier.CompanyProfilePublicId = uploadResult.PublicId;
                        //}
                        switch (file.Type) 
                        {
                            case "CompanyRegUrl":
                                supplier.CompanyRegUrl = uploadResult.Uri.ToString();
                                supplier.CompanyRegPublicId = uploadResult.PublicId;
                                break;
                            case "CompanyTaxUrl":
                                supplier.CompanyTaxUrl = uploadResult.Uri.ToString();
                                supplier.CompanyTaxPublicId = uploadResult.PublicId;
                                break;
                            case "CompanyProfileUrl":
                                supplier.CompanyProfileUrl = uploadResult.Uri.ToString();
                                supplier.CompanyProfilePublicId = uploadResult.PublicId;
                                break;
                            case "CompanyBbbeeUrl":
                                supplier.CompanyBbbeeUrl = uploadResult.Uri.ToString();
                                supplier.CompanyBbbeePublicId = uploadResult.PublicId;
                                break;
                            case "CsdReportUrl":
                                supplier.CsdReportUrl = uploadResult.Uri.ToString();
                                supplier.CsdReportPublicId = uploadResult.PublicId;
                                break;
                            default:
                                break;
                        }
                    }
                
                }


                //Supplier
                var id = input.Id;
                var mappedResult = ObjectMapper.Map(input, supplier);
                mappedResult.Id = id;
                mappedResult.BranchId = branchId;
                mappedResult.AddressId = addressId;
                results = ObjectMapper.Map<SupplierListDto>(await _supplierManager.UpdateAsync(mappedResult));
            }
            return results;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _supplierManager.DeleteAsync(id);
        }
    }
}
