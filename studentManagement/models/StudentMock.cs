using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentManagement.models
{
    public class StudentMock : StudentRepository
    {
        private List<Student> list;

        public StudentMock()
        {
             list = new List<Student>(){ new Student() { id=1,name="xiaoling",className="1班",email="a."},
                 new Student() { id=2,name="xiaoling1",className="1班",email="a."},
                 new Student() { id=3,name="xiaoling2",className="1班",email="a."}
             };
        }

        public Student GetStudent(int id)
        {
            return list.Find(a => a.id == id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return list;
        }
    }
}
