using System;
using System.Collections.Generic;
using System.Linq;
using TravelCountdownApi.Context;
using TravelCountdownApi.Interface;
using TravelCountdownApi.Model;

namespace TravelCountdownApi.Repository
{
    public class TravelRepository : ITravelRepository
    {
        public TravelContext TravelContext { get; set; }

        public TravelRepository(TravelContext travelContext)
        {
            TravelContext = travelContext;
        }

        public IEnumerable<TravelDestination> GetTravelDestinations()
        {
            var d = TravelContext.TravelDestinations;
            return d;

            // var travelDestination = new TravelDestination();
            // travelDestination.Name = "Thailand";
            // travelDestination.Created = DateTime.Now;
            // travelDestination.Updated = DateTime.Now;
            // travelDestination.TravelDate = new DateTime(2018, 12, 26);

            // var destinations = new List<TravelDestination>() { travelDestination };
            // return destinations;
        }

        public IEnumerable<TravelDestination> GetFutureTravelDestinations()
        {
            var d = TravelContext.TravelDestinations;//.Where(x => x.TravelDate > DateTime.Today).ToList();
            return d;

            // var travelDestination = new TravelDestination();
            // travelDestination.Name = "Spanien";
            // travelDestination.Created = DateTime.Now;
            // travelDestination.Updated = DateTime.Now;
            // travelDestination.TravelDate = new DateTime(2018, 05, 23);

            // var travelDestination1 = new TravelDestination();
            // travelDestination1.Name = "Thailand";
            // travelDestination1.Created = DateTime.Now;
            // travelDestination1.Updated = DateTime.Now;
            // travelDestination1.TravelDate = new DateTime(2018, 12, 26);

            // var destinations = new List<TravelDestination>() { travelDestination, travelDestination1 };
            // return destinations;
        }

        public TravelDestination CreateTravelDestination(TravelDestination travelDestination)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTravelDestination(int id)
        {
            throw new System.NotImplementedException();
        }

        public TravelDestination GetTravelDestination(int id)
        {
            throw new System.NotImplementedException();
        }

        public TravelDestination UpdateTravelDestination(TravelDestination travelDestination)
        {
            throw new System.NotImplementedException();
        }
    }
}