namespace Facebook.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class FacebookPagedResult<T>
    {
        [DataMember(Name = "data")]
        public T[] Data { get; set; }
        [DataMember(Name = "paging")]
        public FacebookPaging Paging { get; set; }
    }
}
