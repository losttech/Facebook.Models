namespace Facebook.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class FacebookTargeting
    {
        /// <summary>
        /// ISO 3166 contry codes
        /// </summary>
        [DataMember(Name = "countries")]
        public List<string> Countries { get; } = new List<string>();
        /// <summary>
        /// Locale IDs of some sort
        /// </summary>
        [DataMember(Name = "locales")]
        public List<int> Locales { get; } = new List<int>();
        [DataMember(Name = "regions")]
        public List<uint> Regions { get; } = new List<uint>();
        [DataMember(Name = "cities")]
        public List<uint> Cities { get; } = new List<uint>();
    }
}