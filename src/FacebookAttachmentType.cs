namespace Facebook.Models
{
    using System.Runtime.Serialization;

    public enum FacebookAttachmentType
    {
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "photo")]
        Photo,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "offer")]
        Offer,
        [EnumMember(Value = "event")]
        Event,
    }
}