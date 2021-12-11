using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSanudo.Api.Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }

        public String ShortBody
        {
            get
            {
                if (Body.Length > 100)
                    return Body.Substring(0, 100) + "...";
                else
                    return Body;
            }
        }
    }
}