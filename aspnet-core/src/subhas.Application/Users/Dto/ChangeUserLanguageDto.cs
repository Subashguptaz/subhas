using System.ComponentModel.DataAnnotations;

namespace subhas.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}