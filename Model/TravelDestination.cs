using System;
using System.ComponentModel.DataAnnotations;

namespace TravelCountdownApi.Model
{
    public class TravelDestination
    {
        public int TravelDestinationId { get; set; }

        public string Name { get; set; }

        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string TravelDate { get; set; }

        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Created { get; set; }

        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Updated { get; set; }
    }
}