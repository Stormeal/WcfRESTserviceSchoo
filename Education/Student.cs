using System.Runtime.Serialization;

namespace Education
{
    [DataContract]
    public class Student : Person
    {
        [DataMember]
        public string SchoolClassId { get; set; }
    }
}
