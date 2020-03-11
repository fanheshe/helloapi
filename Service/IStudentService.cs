using System.Collections.Generic;
using helloapi.Model;

namespace helloapi.Service
{
    public interface IStudentService
    {
        void Create(Student student);
        string GetName();
    }
}