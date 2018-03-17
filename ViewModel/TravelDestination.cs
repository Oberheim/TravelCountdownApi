using System;

namespace TravelCountdownApi.ViewModel
{
    public class TravelDestination
    {
        public int TravelDestinationId { get; set; }

        public string Name { get; set; }

        public DateTime TravelDate { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}