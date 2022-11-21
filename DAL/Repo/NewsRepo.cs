using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class NewsRepo : IRepo<News, int>
    {
        public void Add(News obj)
        {
            var db = new NewsPortalEntities();
            db.News.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var db = new NewsPortalEntities();
            var news = db.News.FirstOrDefault(i => i.id == id);
            db.News.Remove(news);
            db.SaveChanges();
        }

        public void Update(News obj)
        {
            var db = new NewsPortalEntities();
            var news = db.News.FirstOrDefault(i => i.id == obj.id);
            news.date = obj.date;
            news.title =obj.title;
            db.SaveChanges();
        }

        public List<News> Get()
        {
            var db = new NewsPortalEntities();
            var news=db.News.ToList();
            return news;
        }

        public News Get(int id)
        {
            var db= new NewsPortalEntities();
            var news = db.News.FirstOrDefault(i => i.id == id);
            return news;

        }
    }
}
