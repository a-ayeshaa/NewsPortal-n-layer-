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
    public class CategoryService
    {
        public static CategoryDTO GetCategory(int id)
        {
            var cRepo= new CategoryRepo();
            var cat = cRepo.Get(id);
            var c = new CategoryDTO()
            {
                id = cat.id,
                name = cat.name,    
            };
            return c;
        }

        public static List<CategoryDTO> GetCategory()
        {
            var cRepo = new CategoryRepo();
            var cats = cRepo.Get();
            var list = new List<CategoryDTO>();
            foreach (var c in cats)
            {
                list.Add(new CategoryDTO()
                {
                    id=c.id,
                    name=c.name,
                });
            }
            return list;
        }

        public static void AddCategory(CategoryDTO c)
        {
            var repo = new CategoryRepo();
            repo.Add(new Category()
            {
               name = c.name,
            }) ;
        }

        public static void UpdateCategory(CategoryDTO c)
        {
            var repo = new CategoryRepo();
            var cat= new Category()
            {
                id =c.id,
                name=c.name,
            };
            repo.Update(cat);
        }

        public static void DeleteCategory(int id)
        {
            var repo = new CategoryRepo();
            repo.Delete(id);
        }
    }
}
