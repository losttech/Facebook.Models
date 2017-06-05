namespace Facebook.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class FacebookPrivacySetting
    {
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "value")]
        public Option Value { get; set; }
        /// <summary>
        /// Comma-separated ID list
        /// </summary>
        [DataMember(Name = "allow")]
        public string Allow { get; set; }
        /// <summary>
        /// Comma-separated ID list
        /// </summary>
        [DataMember(Name = "deny")]
        public string Deny { get; set; }

        public enum Option
        {
            [EnumMember(Value = "EVERYONE")]
            Everyone,
            [EnumMember(Value = "ALL_FRIENDS")]
            Friends,
            [EnumMember(Value = "FRIENDS_OF_FRIENDS")]
            FriendsOfFriends,
            [EnumMember(Value = "SELF")]
            Self,
            [EnumMember(Value = "CUSTOM")]
            Custom,
            [EnumMember(Value = "")]
            Unset,
        }

        public enum FriendSet
        {
            [EnumMember(Value = "ALL_FRIENDS")]
            Friends,
            [EnumMember(Value = "FRIENDS_OF_FRIENDS")]
            FriendsOfFriends,
            [EnumMember(Value = "SOME_FRIENDS")]
            Custom,
        }
    }
}