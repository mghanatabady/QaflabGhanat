using Abp.Application.Services.Dto;

namespace QaflabGhanat.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

