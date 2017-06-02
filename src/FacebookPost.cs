namespace Facebook.Models
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class FacebookPost
    {
        [DataMember(Name = "story")]
        public string Story { get; set; }
        [DataMember(Name = "message")]
        public string Message { get; set; }
        [DataMember(Name = "created_time")]
        public DateTimeOffset CreatedTime { get; set; }
        [DataMember(Name = "id")]
        public string ID { get; set; }
    }
}
