using helloapi.Context;
using helloapi.Model;
using System.Collections.Generic;
using System.Linq;

namespace helloapi.Service
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _schoolContext;

        public StudentService(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public void Create(Student student)
        {
            _schoolContext.Students.Add(student);
            _schoolContext.SaveChanges();
        }

        public string GetName()
        {
            return _schoolContext.Students.First().Name;
        }
    }
}