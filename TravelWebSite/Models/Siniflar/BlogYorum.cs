using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelWebSite.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Yorumlar> Yorumlars { get; set; }
        public IEnumerable<Blog> sonblogs { get; set; }
        public IEnumerable<Yorumlar> sonyorums { get; set; }

        //IEnumerable: interface formatındadır.
    }
}