using Abp.Application.Services.Dto;

namespace SmartUtilities.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

