using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class ContentModel
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FacebookId { get; set; }
    }
}