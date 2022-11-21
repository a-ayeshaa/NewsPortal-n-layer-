using BLL.DTO;
using DAL.EF;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewsService
    {
        public static NewsDTO GetNews(int id)
        {
            var newsRepo = new NewsRepo();
            var news = newsRepo.Get(id);
            var item = new NewsDTO()
            {
                id = news.id,
                category_id=news.category_id,
                title=news.title,
                date=news.date
            };
            return item;
        }

        public static List<NewsDTO> GetNews()
        {
            var newsRepo = new NewsRepo();
            var newslist = newsRepo.Get();
            var list = new List<NewsDTO>();
            foreach(var news in newslist)
            {
                list.Add(new NewsDTO()
                {
                    id = news.id,
                    category_id = news.category_id,
                    title = news.title,
                    date = news.date
                });
            }
            return list;
        }
        public static void AddNews(NewsDTO news)
        {
            var repo= new NewsRepo();
            repo.Add(new News()
            {
                title=news.title,
                category_id=news.category_id,
                date=news.date
            });

        }

        public static void UpdateNews(NewsDTO news)
        {
            var repo = new NewsRepo();
            var n = new News()
            {
                id=news.id,
                title = news.title,
                date = news.date,
                category_id=news.category_id
            };
            repo.Update(n);
        }

        public static void DeleteNews(int id)
        {
            var repo = new NewsRepo();
            repo.Delete(id);
        }
    }
}
