using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApplication1.DataComponent
{
    public class NewsRepooo : INewsRepooo
    {
        private NewsReportDataContext _context = new NewsReportDataContext();
        

        public void AddNews(NewsReport data) 
        {
            data.Date = DateTime.Now;
            _context.NewsReports.InsertOnSubmit(data);
            _context.SubmitChanges();
        }

        public List<NewsReport> GetAllNews()
        {
            var data=_context.NewsReports.ToList();
            data.Reverse();
            return data;
        }

        public NewsReport viewnews(int id) => _context.NewsReports.FirstOrDefault((n) => n.ReportId == id);

        public List<NewsReport> FindNews(string data)
        {
             List<NewsReport> foundeddata = new List<NewsReport>();
            foreach (var item in _context.NewsReports)
            {
                if (item.ReportId.ToString().Contains(data))
                {
                    foundeddata.Add(item);
                }
                else if(item.Title.Contains(data))
                {
                    foundeddata.Add(item);
                }
                else if (item.Description.Contains(data))
                {
                    foundeddata.Add(item);
                }
                else if (item.ReporterName.Contains(data))
                {
                    foundeddata.Add(item);
                }
                else if (item.Date.ToString().Contains(data))
                {
                    foundeddata.Add(item);
                }
            }
            return foundeddata;
        }
    }
}