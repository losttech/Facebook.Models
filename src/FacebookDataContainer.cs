namespace Facebook.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class FacebookDataContainer<T>
    {
        [DataMember(Name = "data")]
        public T Data { get; set; }
    }

    public static class FacebookDataContainer
    {
        public static FacebookDataContainer<T> New<T>() where T : new()
            => new FacebookDataContainer<T> {Data = new T()};
    }
}
