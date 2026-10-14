using Poster.Domain.Entities.Common.Abstractions;

namespace Poster.Domain.Entities.Media.Common.Abstractions
{
    public abstract class BaseMedia : BaseEntity
    {
        protected BaseMedia() : base()
        {
        }

        protected BaseMedia(string name, string path, string contentType)
            : base()
        {
            Name = name;
            Path = path;
            ContentType = contentType;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public string ContentType { get; set; }
        public long Size { get; set; }
    }   
}
