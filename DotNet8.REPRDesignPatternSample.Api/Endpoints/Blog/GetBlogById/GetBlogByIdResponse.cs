namespace DotNet8.REPRDesignPatternSample.Api.Endpoints.Blog.GetBlogById
{
    public class GetBlogByIdResponse
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogAuthor { get; set; }
        public string BlogContent { get; set; }
    }
}
