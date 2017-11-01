using System.Collections.Generic;

namespace Education
{
    public static class SchoolData
    {
        public static List<Student> Students { get; } =
            new List<Student>
            {
                new Student {Id=1, MobileNo = 1234, Name = "Mads", SchoolClassId = "3a" },
                new Student {Id=2, MobileNo = 1246, Name = "Nikoline", SchoolClassId = "3a" },
                new Student {Id=3, MobileNo = 1223, Name = "Bo", SchoolClassId = "3a" },
                new Student {Id=4, MobileNo = 1289, Name = "Else", SchoolClassId = "3a" },
                new Student {Id=5, MobileNo = 1231, Name = "Ib", SchoolClassId = "3a" },
                new Student {Id=6, MobileNo = 1249, Name = "Gitte", SchoolClassId = "3a" },
                new Student {Id=7, MobileNo = 2334, Name = "Henning", SchoolClassId = "2a" },
                new Student {Id=8, MobileNo = 2346, Name = "Mette", SchoolClassId = "2a" },
                new Student {Id=9, MobileNo = 2323, Name = "Bob", SchoolClassId = "2a" },
                new Student {Id=10, MobileNo = 2389, Name = "Elvira", SchoolClassId = "2a" },
                new Student {Id=11, MobileNo = 2331, Name = "Bent", SchoolClassId = "2a" },
                new Student {Id=12, MobileNo = 2349, Name = "Sofie", SchoolClassId = "2a" },
                new Student {Id=13, MobileNo = 3334, Name = "Buster", SchoolClassId = "1b" },
                new Student {Id=14, MobileNo = 3346, Name = "Ane", SchoolClassId = "1b" },
                new Student {Id=15, MobileNo = 3323, Name = "Børge", SchoolClassId = "1b" },
                new Student {Id=16, MobileNo = 3389, Name = "Vigga", SchoolClassId = "1b" },
                new Student {Id=17, MobileNo = 3331, Name = "Viggo", SchoolClassId = "1b" },
                new Student {Id=18, MobileNo = 3349, Name = "Tove", SchoolClassId = "1b" },
                new Student {Id=19, MobileNo = 3349, Name = "Adam", SchoolClassId = "3b" },
                new Student {Id=20, MobileNo = 3349, Name = "Benjamin", SchoolClassId = "3b" },
                new Student {Id=21, MobileNo = 3350, Name = "Carl", SchoolClassId = "3b" },
                new Student {Id=22, MobileNo = 3349, Name = "Dennis", SchoolClassId = "3o" },
                new Student {Id=23, MobileNo = 3349, Name = "Earl", SchoolClassId = "3o" },
            };
        public static List<Teacher> Teachers { get; } = new List<Teacher>
        {
            new Teacher {Id=1, Name = "Martin", MobileNo = 123 },
            new Teacher {Id=2, Name = "Vibeke", MobileNo = 127 },
            new Teacher {Id=3, Name = "Anders", MobileNo = 122 },
            new Teacher {Id=4, Name = "Michael H", MobileNo = 992 },
            new Teacher {Id=5, Name = "Mohammed", MobileNo = 982 },
            new Teacher {Id=9, Name = "Peter", MobileNo = 129 },
            new Teacher {Id=10, Name = "Michael C", MobileNo = 132 },
            new Teacher {Id=100, Name = "Eik", MobileNo = 160 }
        };

        public static List<SchoolClass> SchoolClasses { get; } = new List<SchoolClass>
        {
            new SchoolClass { SchoolClassId = "3a", SchoolClassName = "Ro31Easj", Address = "Jernbanegade" },
            new SchoolClass { SchoolClassId = "3b", SchoolClassName = "ro16da2b3-3b", Address = "Jernbanegade" },
            new SchoolClass { SchoolClassId = "3o", SchoolClassName = "ro16cs2o3-3o", Address = "Jernbanegade" },
            new SchoolClass { SchoolClassId = "2a", SchoolClassName = "Ro21Easj", Address = "Elisagårdsvej" },
            new SchoolClass { SchoolClassId = "1b", SchoolClassName = "Ro1Easj", Address = "Maglegårdsvej" },
        };

        public static List<TeacherClass> TeacherClasses { get; } = new List<TeacherClass>
        {
            new TeacherClass {TeacherId = 1, SchoolClassId = "3a"},
            new TeacherClass { TeacherId = 2, SchoolClassId = "3a"},
            new TeacherClass { TeacherId = 9, SchoolClassId = "3a"},
            new TeacherClass { TeacherId = 3, SchoolClassId = "3b"},
            new TeacherClass { TeacherId = 3, SchoolClassId = "3o"},
            new TeacherClass { TeacherId = 10, SchoolClassId = "3o"},
            new TeacherClass { TeacherId = 5, SchoolClassId = "3o"},
            new TeacherClass { TeacherId = 4, SchoolClassId = "3b"},
        };
    }
}