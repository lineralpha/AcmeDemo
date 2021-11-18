using System.ComponentModel.DataAnnotations;

namespace AcmeDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}