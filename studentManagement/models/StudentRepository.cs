using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentManagement.models
{
    public interface StudentRepository
    {
        Student GetStudent(int id);

        IEnumerable<Student> GetStudents();
    }
}
