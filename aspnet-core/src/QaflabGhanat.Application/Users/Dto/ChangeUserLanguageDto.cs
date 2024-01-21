using System.ComponentModel.DataAnnotations;

namespace QaflabGhanat.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}