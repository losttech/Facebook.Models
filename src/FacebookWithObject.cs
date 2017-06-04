namespace Facebook.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class FacebookWithObject
    {
        [DataMember(Name = "data")]
        public List<FacebookProfile> Data { get; } = new List<FacebookProfile>();
    }
}