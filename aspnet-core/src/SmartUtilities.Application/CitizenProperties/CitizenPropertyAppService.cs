using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Runtime.Session;
using Abp.UI;
using AutoMapper;
using Developmenthub.SmartMetering;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using SmartUtilities.Addresses;
using SmartUtilities.Assets;
using SmartUtilities.Authorization.Users;
using SmartUtilities.CitizenProperties.Dtos;
using SmartUtilities.CitizenPropertyUsers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenProperties
{
    public class CitizenPropertyAppService : SmartUtilitiesAppServiceBase,  ICitizenPropertyAppService
    {
        private readonly IRepository<CitizenProperty, Guid> _propertyRepository;
        private readonly IRepository<Address, Guid> _addressRepository;
        private readonly IRepository<User, long> _userRepo;
        private readonly IWebHostEnvironment _environment;
        private readonly IRepository<CitizenPropertyUser, Guid> _citizenPropertyUser;
        //private readonly IRe
        //I have to use userManager to create a USER and
        //set the role of the user while creating

        public CitizenPropertyAppService(
            IRepository<CitizenProperty, Guid> propertyRepository,
            IRepository<Address, Guid> addressRepository,
            IRepository<User, long> userRepo,
            IWebHostEnvironment environment ,
            IRepository<CitizenPropertyUser, Guid> citizenPropUser)
        {
            _propertyRepository = propertyRepository;
            _addressRepository = addressRepository;
            _userRepo = userRepo;
            _environment = environment;
            _citizenPropertyUser = citizenPropUser;
        }

        public async Task<CitizenPropertyDto> CreateAsync(CreatePropertyDto createPropertyDto)
        {
            //Mapping the AddressDto to Address
            var address = ObjectMapper.Map<Address>(createPropertyDto.Address);
            Guid addressId = await _addressRepository.InsertAndGetIdAsync(address);
            await CurrentUnitOfWork.SaveChangesAsync();
            //Mapping the CreateUserInputDto to User
            var user = createPropertyDto.User;
            long userId = await _userRepo.InsertAndGetIdAsync(new User
            {
                Name = user.Name,
                EmailAddress = user.EmailAddress,
                Surname = user.Surname,
                NormalizedEmailAddress = user.EmailAddress,
                NormalizedUserName = user.EmailAddress,
                Password = user.IdentityNo,
                IdentityNo = user.IdentityNo,
                PhoneNumber = user.PhoneNumber,
                UserName = user.EmailAddress,
                AddressId = addressId,
                IsActive = true
            });
            await CurrentUnitOfWork.SaveChangesAsync();
            var property = new CitizenProperty
            {
                ErfNo = createPropertyDto.ErfNo,
                AddressId = addressId,
                Type = createPropertyDto.Type,
                TenantId = AbpSession.TenantId,
                WardId = createPropertyDto.WardId,
                Consumption = createPropertyDto.Consumption
            };
            var citizenProperty = await _propertyRepository.InsertAsync(property);
            await CurrentUnitOfWork.SaveChangesAsync();

            await _citizenPropertyUser.InsertAsync(new CitizenPropertyUser
            {
                PropertyId = citizenProperty.Id,
                PropertyOwnerId = userId,
                TenantId = AbpSession.TenantId
            });
            await CurrentUnitOfWork.SaveChangesAsync();

            //try email
            string body = string.Empty;
            var path = Path.Combine(_environment.WebRootPath, "EmailTemplate/property-registration.html");

            using (StreamReader reader = new StreamReader(path))
            {
                body = reader.ReadToEnd();
            }

            string link = createPropertyDto.BaseUrl;
            body = body.Replace("#Username", user.EmailAddress);
            body = body.Replace("#Password", user.IdentityNo);
            body = body.Replace("#Link", link);

           await Emailer.Send(to: user.EmailAddress, subject: "Any Utilities New Property Added!!", body: body, isBodyHtml: true);

            return ObjectMapper.Map<CitizenPropertyDto>(citizenProperty);
        }

        public async Task<AddPropertyUserDto> AddNewUser(AddPropertyUserDto input)
        {
            
            long propertyOwnerId = input.PropertyOwnerId;
            var result = await _citizenPropertyUser.InsertAsync(new CitizenPropertyUser
            {
                PropertyId = input.PropertyId,
                PropertyOwnerId = propertyOwnerId,
                TenantId = AbpSession.TenantId
            });
            await CurrentUnitOfWork.SaveChangesAsync();

            return ObjectMapper.Map<AddPropertyUserDto>(result);
        }


        public async Task<ListResultDto<ListPropertyDto>> GetAllAsync()
        {
            var properties = new List<CitizenProperty>();
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                properties = await _propertyRepository
                    .GetAll()
                    //.Where(x => x.TenantId == AbpSession.GetTenantId())
                    .Include(x => x.PropertyUsers)
                    .ThenInclude(x => x.User)
                    .ThenInclude(x => x.Properties)
                    .Include(x => x.Address)
                    .ToListAsync();
            }

            return new ListResultDto<ListPropertyDto>(ObjectMapper.Map<List<ListPropertyDto>>(properties));
        }

        public async Task<CitizenPropertyDto> GetAsync(Guid id)
        {
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant, AbpDataFilters.SoftDelete))
            {
                var property = await _propertyRepository
                .GetAll()
                .IgnoreQueryFilters()
                .Include(s => s.PropertyDevices)
                .Include(x => x.PropertyUsers)
                .ThenInclude(user => user.User)
                .ThenInclude(user => user.Roles)
                .Include(x => x.Ward)
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id == id);
                return ObjectMapper.Map<CitizenPropertyDto>(property);
            }
        }

        public async Task<CitizenPropertyDto> SearchErf(string erfnumber)
        {
            var property = await _propertyRepository
               .GetAll()
               .IgnoreQueryFilters()
               .Include(x => x.PropertyUsers)
               .ThenInclude(user => user.User)
               .Include(w => w.Ward)
               .Include(x => x.Address)
               .FirstOrDefaultAsync(x => x.ErfNo == erfnumber);
            return ObjectMapper.Map<CitizenPropertyDto>(property);

        }

        public async Task<CitizenPropertyDto> UpdateAsync(CitizenPropertyDto input)
        {
            var property = await _propertyRepository.GetAsync(input.Id);

            if (property == null)
            {
                throw new UserFriendlyException("Property was not updated");
            }
            var propertyId = property.Id;
            ObjectMapper.Map(input, property);
            property.Id = propertyId;

            return ObjectMapper.Map<CitizenPropertyDto>(await _propertyRepository.UpdateAsync(property));
        }
    }
}
