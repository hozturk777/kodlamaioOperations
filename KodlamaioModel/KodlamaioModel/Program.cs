

using KodlamaioModel.Business.Concrete;
using KodlamaioModel.DataAccess.Concrete;
using KodlamaioModel.Entity.Concrete;

CourseManager courseManager = new CourseManager(new CourseDal());
CategoryManager categoryManager = new CategoryManager(new CategoryDal());

List<Course> courses = courseManager.GetAll();
List<Category> categories = categoryManager.GetAll();

foreach (var course in courses)
{
    
    Console.WriteLine(course.Id);
    Console.WriteLine(course.Name);
    Console.WriteLine(course.Description);
    Console.WriteLine(categories.FirstOrDefault(x => x.Id == course.CategoryId).Name);
}