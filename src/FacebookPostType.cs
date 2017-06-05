namespace Facebook.Models
{
    using System.Runtime.Serialization;

    public enum FacebookPostType
    {
        [EnumMember(Value = "")]
        Unknown,
        [EnumMember(Value = "mobile_status_update")]
        Mobile,
        [EnumMember(Value = "created_note")]
        Note,
        [EnumMember(Value = "added_photos")]
        Photos,
        [EnumMember(Value = "added_video")]
        Video,
        [EnumMember(Value = "shared_story")]
        Story,
        [EnumMember(Value = "created_group")]
        Group,
        [EnumMember(Value = "created_event")]
        Event,
        [EnumMember(Value = "wall_post")]
        WallPost,
        [EnumMember(Value = "app_created_story")]
        AppCreatedStory,
        [EnumMember(Value = "published_story")]
        PublishedStory,
        [EnumMember(Value = "tagged_in_photo")]
        Tagged,
        [EnumMember(Value = "approved_friend")]
        ApprovedFriend,
    }
}