using KodlamaioModel.Business.Abstract;
using KodlamaioModel.DataAccess.Abstract;
using KodlamaioModel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModel.Business.Concrete
{
    public class InstructorManager : IGenericService<Instructor>
    {
        private readonly IGenericDal<Instructor> _instructor;

        public InstructorManager(IGenericDal<Instructor> instructor)
        {
            _instructor = instructor;
        }

        public void Add(Instructor entity)
        {
            _instructor.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _instructor?.Delete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _instructor.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructor.GetById(id);
        }

        public void Update(Instructor entity)
        {
            _instructor.Update(entity);
        }
    }
}
