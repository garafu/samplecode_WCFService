namespace WcfService
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Book
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "author")]
        public string Author { get; set; }

        [DataMember(Name = "isbn")]
        public string ISBN { get; set; }

        [DataMember(Name = "publisher")]
        public string Publisher { get; set; }
    }
}