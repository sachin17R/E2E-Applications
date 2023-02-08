using System.Collections.Generic;

namespace NewsApplication1.DataComponent
{
    public interface INewsRepooo
    {
        void AddNews(NewsReport data);
        List<NewsReport> FindNews(string data);
        NewsReport viewnews(int id);
        List<NewsReport> GetAllNews();
    }
}