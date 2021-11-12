using System.ComponentModel.DataAnnotations;

namespace SmartUtilities.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}