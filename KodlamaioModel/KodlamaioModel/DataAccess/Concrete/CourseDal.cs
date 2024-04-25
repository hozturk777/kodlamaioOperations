using KodlamaioModel.DataAccess.Abstract;
using KodlamaioModel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModel.DataAccess.Concrete
{
    public class CourseDal : IGenericDal<Course>
    {
        List<Course> course;

        public CourseDal()
        {
            course = new List<Course> { 
            
                new Course()
                {
                    Id = 1,
                    Name = "Course 1",
                    CategoryId = 1,
                    InstructorId = 1,
                    Description = "Course 1 Description"
                },

                new Course()
                {
                    Id = 2,
                    Name = "Course 2",
                    CategoryId = 2,
                    InstructorId = 2,
                    Description = "Course 2 Description"
                },

                new Course()
                {
                    Id = 3,
                    Name = "Course 3",
                    CategoryId = 2,
                    InstructorId = 2,
                    Description = "Course 3 Description"
                },
            };
        }

        public void Add(Course entity)
        {
            course.Add(entity);
            Console.WriteLine("Course Added!");
        }

        public void Delete(Course entity)
        {
            var result = course.FirstOrDefault(x => x.Id == entity.Id);
            if (result != null)
            {                
                course.Remove(result);
                Console.WriteLine("Remove Operation Success");               
            }
            else
            {
                Console.WriteLine("Check Parameter");
            }            
        }

        public List<Course> GetAll()
        {
            return course;
        }

        public Course GetById(int id)
        {
            var result = course.FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                Console.WriteLine("Check Parameter");
                return null;
            }
            else
            {
                return result;
            }
        }

        public void Update(Course entity)
        {
            var result = course.FirstOrDefault(x => x.Id == entity.Id);
            if (result != null)
            {
                result.Name = entity.Name;
                result.CategoryId = entity.CategoryId;
                result.Description = entity.Description;
                result.InstructorId = entity.InstructorId;
                Console.WriteLine("Update Operation Success");
            }
            else
            {
                Console.WriteLine("Check Parameter");
            }
        }
    }
}
