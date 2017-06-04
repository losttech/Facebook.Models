namespace Facebook.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class FacebookAuthor
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
