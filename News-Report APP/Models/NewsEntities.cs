using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApplication1.Models
{
    public class NewsEntities
    {
        public int ReportId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReporterName { get; set; }
        public string Date { get; set; }
        public string Place { get; set; }
        public string Image { get; set; }
    }
}