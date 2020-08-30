using System.ComponentModel.DataAnnotations;

namespace NflStatsDotNet.Services
{
    public class NerdServiceOptions
    {
        [Required(AllowEmptyStrings = false)]
        public string BaseUrl { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Token { get; set; }
    }
}