using Poster.Domain.Entities.Media.Common.Abstractions;

namespace Poster.Domain.Entities.Posts.Media
{
    public sealed class Image : BaseMedia
    {
        public Image() : base()
        {
        }

        public Image(Guid id, string path, Guid standardPostId,
            StandardPost standardPost = null) 
            : base(id, path)
        {
            StandardPostId = standardPostId;
            StandardPost = standardPost;
        }

        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
    }
}
