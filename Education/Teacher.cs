using System.Runtime.Serialization;

namespace Education
{
    [DataContract]
    public class Teacher : Person
    {
        [DataMember]
        public int? Salary { get; set; }
    }
}
