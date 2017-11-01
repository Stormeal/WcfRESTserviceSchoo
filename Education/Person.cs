using System.Runtime.Serialization;

namespace Education
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int MobileNo { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}