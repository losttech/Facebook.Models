namespace Facebook.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class FacebookLikesSummary
    {
        [DataMember(Name = "total_count")]
        public long Count { get; set; }
        [DataMember(Name = "can_like")]
        public bool CanLink { get; set; }
        [DataMember(Name = "has_liked")]
        public bool HasLiked { get; set; }
    }
}