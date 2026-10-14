using Poster.Domain.Entities.Media.Common.Abstractions;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Media.Posts
{
    public sealed class Video : BaseMedia
    {
        public Video() : base()
        {
        }

        public Video(string name, string path, string contentType, 
            Guid videoPostId, VideoPost videoPost = null)
            : base(name, path, contentType)
        {
            VideoPostId = videoPostId;
            VideoPost = videoPost;
        }

        public Guid VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
    }
}
