using KodlamaioModel.DataAccess.Abstract;
using KodlamaioModel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModel.Business.Concrete
{
    public class CategoryManager : IGenericDal<Category>
    {
        private readonly IGenericDal<Category> _category;

        public CategoryManager(IGenericDal<Category> category)
        {
            _category = category;
        }

        public void Add(Category entity)
        {
            _category.Add(entity);
        }

        public void Delete(Category entity)
        {
            _category.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _category.GetAll();
        }

        public Category GetById(int id)
        {
            return _category.GetById(id);
        }

        public void Update(Category entity)
        {
            _category.Update(entity);
        }
    }
}
