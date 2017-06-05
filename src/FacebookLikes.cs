namespace Facebook.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class FacebookLikes
    {
        [DataMember(Name = "summary")]
        public FacebookLikesSummary Summary { get; set; }
    }
}
