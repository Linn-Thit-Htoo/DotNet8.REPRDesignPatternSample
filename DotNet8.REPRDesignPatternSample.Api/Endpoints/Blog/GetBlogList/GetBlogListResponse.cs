﻿using DotNet8.REPRDesignPatternSample.Models.Features.Blog;

namespace DotNet8.REPRDesignPatternSample.Api.Endpoints.Blog.GetBlogList;

public class GetBlogListResponse
{
    public List<BlogModel> DataLst { get; set; }
}
