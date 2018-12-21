using System.ComponentModel.DataAnnotations;

namespace Graby.Life.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}