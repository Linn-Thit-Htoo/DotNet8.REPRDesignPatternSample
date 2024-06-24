using DotNet8.REPRDesignPatternSample.DbService.AppDbContexts;
using DotNet8.REPRDesignPatternSample.Models.Features.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.REPRDesignPatternSample.Mapper
{
    public static class ChangeModel
    {
        public static BlogModel Change(this Tbl_Blog dataModel)
        {
            return new BlogModel
            {
                BlogId = dataModel.BlogId,
                BlogTitle = dataModel.BlogTitle,
                BlogAuthor = dataModel.BlogAuthor,
                BlogContent = dataModel.BlogContent
            };
        }
    }
}
