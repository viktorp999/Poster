using Poster.Core.Entities.Common.Abstractions;

namespace Poster.Core.Entities.Media.Common.Abstractions
{
    public abstract class BaseMedia : BaseEntity<Guid>
    {
        protected BaseMedia() : base()
        {
        }

        protected BaseMedia(Guid id, string path)
            : base(id)
        {
            Path = path;
        }

        public string Path { get; set; }
    }
}
