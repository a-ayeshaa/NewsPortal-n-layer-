using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CategoryRepo : IRepo<Category, int>
    {
        public void Add(Category obj)
        {
            var db = new NewsPortalEntities();
            db.Categories.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var db = new NewsPortalEntities();
            var news = (from i in db.News
                        where i.category_id == id
                        select i).ToList();
            foreach (var item in news)
            {
                db.News.Remove(item);
                db.SaveChanges();

            }
            var cat = db.Categories.FirstOrDefault(i => i.id == id);
            db.Categories.Remove(cat);
            db.SaveChanges();

            

        }

        public void Update(Category obj)
        {
            var db = new NewsPortalEntities();
            var cat = db.Categories.FirstOrDefault(i => i.id == obj.id);
            cat.name = obj.name;
            db.SaveChanges();
        }

        public List<Category> Get()
        {
            var db = new NewsPortalEntities();
            var cat = db.Categories.ToList();
            return cat;
        }

        public Category Get(int id)
        {
            var db = new NewsPortalEntities();
            var cat = db.Categories.FirstOrDefault(i => i.id == id);
            return cat;

        }
    }
}
