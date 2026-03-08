using Poster.Domain.Entities.Media.Common.Abstractions;

namespace Poster.Domain.Entities.Posts.Media
{
    public sealed class Video : BaseMedia
    {
        public Video() : base()
        {
        }

        public Video(Guid id, string path, Guid videoPostId, 
            VideoPost videoPost = null)
            : base(id, path)
        {
            VideoPostId = videoPostId;
            VideoPost = videoPost;
        }

        public Guid VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
    }
}
