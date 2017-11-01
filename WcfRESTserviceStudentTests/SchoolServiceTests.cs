using System.Collections.Generic;
using System.Linq;
using Education;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WcfRESTserviceStudent.Tests
{
    [TestClass]
    public class SchoolServiceTests
    {
        [TestMethod]
        public void GetSchoolClassDataTest()
        {

        }

        [TestMethod]
        public void GetAllTeachersTest()
        {
            ISchoolService service = new SchoolService();
            List<Teacher> teachers = service.GetAllTeachers();
            Assert.IsTrue(teachers.Count > 0);

            teachers = service.GetAllTeachers("a");
            Assert.AreEqual(4, teachers.Count);
        }

        [TestMethod]
        public void GetAllTeachersNameTest()
        {
            ISchoolService service = new SchoolService();
            IEnumerable<string> teacherNames = service.GetAllTeachersName();
            Assert.IsTrue(teacherNames.Contains("Anders"));
        }

        [TestMethod]
        public void GetTeachersByIdTest()
        {
            ISchoolService service = new SchoolService();
            Teacher teacher= service.GetTeacherById("1");
            Assert.AreEqual("Martin", teacher.Name);
            teacher = service.GetTeacherById("0");
            Assert.IsNull(teacher);
        }

        [TestMethod]
        public void GetTeachersByNameTest()
        {
            ISchoolService service = new SchoolService();
            IEnumerable<Teacher> teachers = service.GetTeachersByName("Martin");
            Assert.AreEqual(1, teachers.Count());
        }

        [TestMethod]
        public void GetSchoolClassesByTeacherIdTest()
        {
            ISchoolService service = new SchoolService();
            IEnumerable<SchoolClass> classes = service.GetSchoolClassesByTeacherId("1");
            Assert.AreEqual(1, classes.Count());
        }

        [TestMethod]
        public void GetTeachersByStudentIdTest()
        {
            // TODO test
        }

        [TestMethod]
        public void GetStudentsByTeacherIdTest()
        {
            ISchoolService service = new SchoolService();
            IEnumerable<Student> students = service.GetStudentsByTeacherId("1");
            Assert.AreEqual(6, students.Count());
        }

        [TestMethod]
        public void DeleteTeacherTest()
        {
            ISchoolService service = new SchoolService();
            int count = service.GetAllTeachers().Count;
            service.DeleteTeacher("9");
            Assert.AreEqual(count-1, service.GetAllTeachers().Count);
        }

        [TestMethod]
        public void AddTeacherTest()
        {
            ISchoolService service = new SchoolService();
            List<Teacher> teachers = service.GetAllTeachers();
            int count = teachers.Count;
            service.AddTeacher(new Teacher { Id = 123, Name = "Zimba" });
            teachers = service.GetAllTeachers();
            int newCount = teachers.Count;
            Assert.AreEqual(count + 1, newCount);
        }

        [TestMethod]
        public void UpdateTeacherTest()
        {
            ISchoolService service = new SchoolService();
            Teacher teacher1 = service.GetTeacherById("1");

            Teacher newInfo = new Teacher {Salary = 123456};
            service.UpdateTeacher("1", newInfo);
            Teacher teacher1b = service.GetTeacherById("1");
            Assert.AreEqual(teacher1.Id, teacher1b.Id);
            Assert.AreEqual(teacher1.Name, teacher1b.Name);
            Assert.AreEqual(teacher1.MobileNo, teacher1b.MobileNo);
            Assert.AreEqual(123456, teacher1b.Salary);
        }
    }
}