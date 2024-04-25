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
    public class CourseManager : IGenericService<Course>
    {
        private readonly IGenericDal<Course> _course;

        public CourseManager(IGenericDal<Course> course)
        {
            _course = course;
        }

        public void Add(Course entity)
        {
            _course.Add(entity);
        }

        public void Delete(Course entity)
        {
            _course?.Delete(entity);
        }

        public List<Course> GetAll()
        {
            return _course.GetAll();
        }

        public Course GetById(int id)
        {
            return _course.GetById(id);
        }

        public void Update(Course entity)
        {
            _course.Update(entity);
        }
    }
}
