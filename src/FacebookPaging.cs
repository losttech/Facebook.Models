namespace Facebook.Models
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class FacebookPaging
    {
        [DataMember(Name = "next")]
        public Uri Next { get; set; }
        [DataMember(Name = "previous")]
        public Uri Previous { get; set; }
    }
}