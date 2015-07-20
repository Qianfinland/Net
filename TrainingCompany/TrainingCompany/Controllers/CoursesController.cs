using System.Collections.Generic;
using System.Web.Http;

namespace TrainingCompany.Controllers
{
    public class CoursesController : ApiController
    {
        public IEnumerable<course> Get()
        {
            return courses;
        }
        static List<course> courses = InitCourses();
        private static List<course> InitCourses()
        {
            var ret = new List<course>();
            ret.Add(new course { id = 0, title = "Nunit" });
            ret.Add(new course { id = 1, title = "ASP.NET Web API" });
            return ret;
        }
    }

    public class course
    {
        public int id;
        public string title;
    }
}
