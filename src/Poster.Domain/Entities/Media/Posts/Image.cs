using Poster.Domain.Entities.Media.Common.Abstractions;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Media.Posts
{
    public sealed class Image : BaseMedia
    {
        public Image() : base()
        {
        }

        public Image(string path, StandardPost standardPost = null) 
            : base(path)
        {
            StandardPost = standardPost;
        }

        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
    }
}
