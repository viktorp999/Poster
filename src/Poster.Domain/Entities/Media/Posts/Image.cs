using Poster.Domain.Entities.Media.Common.Abstractions;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Media.Posts
{
    public sealed class Image : BaseMedia
    {
        public Image() : base()
        {
        }

        public Image(string name ,string path, string contentType, 
            Guid standardPostId, StandardPost standardPost = null) 
            : base(name, path, contentType)
        {
            StandardPostId = standardPostId;
            StandardPost = standardPost;
        }

        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
    }
}
