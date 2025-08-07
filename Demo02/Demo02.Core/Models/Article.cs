using System;

namespace Demo02.Core.Models
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Content { get; set; }
        public int BookId { get; set; }
    }
}
