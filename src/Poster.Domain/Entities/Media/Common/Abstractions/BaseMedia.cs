using Poster.Domain.Entities.Common.Abstractions;

namespace Poster.Domain.Entities.Media.Common.Abstractions
{
    public abstract class BaseMedia : BaseEntity
    {
        protected BaseMedia() : base()
        {
        }

        protected BaseMedia(string path)
            : base()
        {
            Path = path;
        }
        public string Path { get; set; }
    }   
}
