﻿namespace Facebook.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Threading;

    [DataContract]
    public sealed class FacebookPost
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }
        [DataMember(Name = "admin_creator")]
        public List<FacebookAuthor> Creators { get; } = new List<FacebookAuthor>();
        [DataMember(Name = "application")]
        public FacebookApplication MadeInApplication { get; set; }
        /// <summary>
        /// Link caption
        /// </summary>
        [DataMember(Name = "caption")]
        public string LinkCaption { get; set; }
        [DataMember(Name = "created_time")]
        public DateTime CreateTime { get; set; }
        [DataMember(Name = "description")]
        public string LinkDescription { get; set; }
        [DataMember(Name = "profile")]
        public FacebookProfile Profile { get; set; }
        /// <summary>
        /// The icon for this type of the post
        /// </summary>
        [DataMember(Name = "icon")]
        public Uri TypeIcon { get; set; }
        [DataMember(Name = "is_hidden")]
        public bool IsHidden { get; set; }
        [DataMember(Name = "is_published")]
        public bool IsPublished { get; set; }
        [DataMember(Name = "link")]
        public Uri Link { get; set; }
        [DataMember(Name = "message")]
        public string Message { get; set; }
        [DataMember(Name = "name")]
        public string LinkName { get; set; }
        [DataMember(Name = "object_id")]
        public string AttachmentID { get; set; }
        [DataMember(Name = "parent_id")]
        public string ParentID { get; set; }
        [DataMember(Name = "permalink_url")]
        public Uri Permalink { get; set; }
        [DataMember(Name = "picture")]
        public Uri Picture { get; set; }
        [DataMember(Name = "full_picture")]
        public Uri FullPicture { get; set; }
        [DataMember(Name = "place")]
        public FacebookPlace Place { get; set; }
        [DataMember(Name = "privacy")]
        public FacebookPrivacySetting Privacy { get; set; }
        [DataMember(Name = "properties")]
        public List<FacebookAttachmentProperty> AttachmentProperties { get; } = new List<FacebookAttachmentProperty>();
        [DataMember(Name = "shares")]
        public long ShareCount { get; set; }
        [DataMember(Name = "source")]
        public Uri AttachmentSource { get; set; }
        [DataMember(Name = "status_type")]
        public FacebookPostType Type { get; set; }
        /// <summary>
        /// Action autogenerated text
        /// </summary>
        [DataMember(Name = "story")]
        public string Story { get; set; }
        [DataMember(Name = "targeting")]
        public FacebookTargeting Targeting { get; set; }
        /// <summary>
        /// Mentioned or targeted in this post
        /// </summary>
        [DataMember(Name = "to")]
        public FacebookDataContainer<List<FacebookProfile>> To { get; set; } = FacebookDataContainer.New<List<FacebookProfile>>();
        [DataMember(Name = "type")]
        public FacebookAttachmentType AttachmentType { get; set; }
        [DataMember(Name = "updated_time")]
        public DateTime? UpdateTime { get; set; }
        [DataMember(Name = "with_tags")]
        public FacebookWithObject With { get; set; }
        [DataMember(Name = "likes")]
        public FacebookLikes Likes { get; set; }
    }
}
