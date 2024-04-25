using KodlamaioModel.DataAccess.Abstract;
using KodlamaioModel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModel.DataAccess.Concrete
{
    public class InstructorDal : IGenericDal<Instructor>
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            instructors = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = 1,
                    Name = "Instructor 1",
                },
                new Instructor()
                {
                    Id = 2,
                    Name = "Instructor 2"
                },
            };
        }

        public void Add(Instructor entity)
        {
            instructors.Add(entity);
            Console.WriteLine("Instructor Added");
        }

        public void Delete(Instructor entity)
        {
            var result = instructors.FirstOrDefault(x => x.Id == entity.Id);
            if (result != null)
            {
                instructors.Remove(result);
                Console.WriteLine("Delete Operation Success");
            }
            else
            {
                Console.WriteLine("Check Parameter");
            }
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            var result = instructors.FirstOrDefault(x => x.Id == id);
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

        public void Update(Instructor entity)
        {
            var result= instructors.FirstOrDefault(x => x.Id == entity.Id);
            if (result != null)
            {
                result.Name = entity.Name;
            }
            else
            {
                Console.WriteLine("Check Parameter");
            }
        }
    }
}
