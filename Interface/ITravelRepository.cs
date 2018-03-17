using System.Collections.Generic;
using TravelCountdownApi.Model;

namespace TravelCountdownApi.Interface
{
    public interface ITravelRepository
    {
        TravelDestination GetTravelDestination(int id);

        IEnumerable<TravelDestination> GetTravelDestinations();

        IEnumerable<TravelDestination> GetFutureTravelDestinations();

        void DeleteTravelDestination(int id);

        TravelDestination UpdateTravelDestination(TravelDestination travelDestination);

        TravelDestination CreateTravelDestination(TravelDestination travelDestination);
    }
}