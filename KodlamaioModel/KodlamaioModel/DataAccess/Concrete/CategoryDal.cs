using KodlamaioModel.DataAccess.Abstract;
using KodlamaioModel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModel.DataAccess.Concrete
{
    public class CategoryDal : IGenericDal<Category>
    {
        List<Category> categories;

        public CategoryDal()
        {
            categories = new List<Category>()
            { 
                new Category()
                {
                    Id = 1,
                    Name = "Category 1",
                },
                new Category()
                {
                    Id = 2,
                    Name = "Category 2",
                },
            };
        }

        public void Add(Category entity)
        {
            categories.Add(entity);
            Console.WriteLine("Category Added");
        }

        public void Delete(Category entity)
        {
            var result = categories.FirstOrDefault(x => x.Id == entity.Id);
            if (result != null)
            {
                categories.Remove(result);
                Console.WriteLine("Delete Operation Success");
            }
            else
            {
                Console.WriteLine("Check Parameter");
            }
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            var result = categories.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Check Parameter");
                return null;
            }
        }

        public void Update(Category entity)
        {
            var result = categories.FirstOrDefault(x => x.Id == entity.Id);
            if (result != null)
            {
                result.Name = entity.Name;
                Console.WriteLine("Update Operation Success");
            }
            else
            {
                Console.WriteLine("Check Parameter");
            }
        }
    }
}
