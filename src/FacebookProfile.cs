namespace Facebook.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class FacebookProfile
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}