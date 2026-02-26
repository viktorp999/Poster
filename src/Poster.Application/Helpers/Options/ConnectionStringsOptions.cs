using System.ComponentModel.DataAnnotations;

namespace Poster.Application.Helpers.Options
{
    public class ConnectionStringsOptions
    {
        public const string SectionName = "ConnectionStrings";

        [Required(AllowEmptyStrings = false)]
        public string PosterConnection { get; set; } = string.Empty;
    }
}
