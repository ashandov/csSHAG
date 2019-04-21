using System;
using System.Runtime.Serialization;

namespace Serialization
{

    [Serializable]
    public class Person : ISerializable
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public Person() { }
        private Person(SerializationInfo info,
        StreamingContext context)
        {
            Name = info.GetString("PersonName").ToUpper(); DateBirth = info.GetDateTime("DateBirth").ToUniversalTime();
        }

        void ISerializable.GetObjectData(SerializationInfo
        info, StreamingContext context)
        {
            info.AddValue("PersonName", Name.ToLower()); info.AddValue("DateBirth",
            DateBirth.ToLocalTime());
        }
        public override string ToString()
        {
            return $"Name: {Name},Date of Birth: { DateBirth}."; }
        }
    }
