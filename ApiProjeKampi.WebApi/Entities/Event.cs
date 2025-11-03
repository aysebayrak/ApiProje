namespace ApiProjeKampi.WebApi.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string EventDescription { get; set; }
        public string EventImageUrl { get; set; }
        public bool EventStatus { get; set; }
        public decimal EventPrice { get; set; }


    }
}
