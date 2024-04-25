using KodlamaioModel.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioModel.Entity.Concrete
{
    public class Instructor : BaseEntity
    {
        public ICollection<Course> courses { get; set; }
    }
}
