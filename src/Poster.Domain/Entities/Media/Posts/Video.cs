using Poster.Domain.Entities.Media.Common.Abstractions;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Media.Posts
{
    public sealed class Video : BaseMedia
    {
        public Video() : base()
        {
        }

        public Video(string path, VideoPost videoPost = null)
            : base(path)
        {
            VideoPost = videoPost;
        }

        public Guid VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
    }
}
