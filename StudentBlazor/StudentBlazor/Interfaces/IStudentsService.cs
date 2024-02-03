using StudentBlazor.Models;
using System.Collections.Generic;

namespace StudentBlazor.Interfaces
{
    public interface IStudentsService
    {
        public IEnumerable<Student> GetStudents();
        public void DeleteStudent(Student student);
        public void SetStudentInfo(Student student);
        public Student GetStudentInfo();
    }
}
