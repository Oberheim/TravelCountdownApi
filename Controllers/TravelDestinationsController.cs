using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelCountdownApi.Interface;
using TravelCountdownApi.ViewModel;

namespace TravelCountdownApi.Controllers
{
    [Route("api/[controller]")]
    public class TravelDestinationsController : Controller
    {
        public ITravelRepository TravelRepository  { get; set; }

        public TravelDestinationsController(ITravelRepository travelRepository)
        {
            TravelRepository = travelRepository;
        }

        // GET api/TravelDestinations
        [HttpGet]
        public IEnumerable<TravelDestination> Get()
        {
            var destinations = TravelRepository.GetTravelDestinations();
            
            var destinationViewModels = new List<TravelDestination>();
            foreach(var destination in destinations)
            {
                var destinationViewModel = new TravelDestination();

                destinationViewModel.Name = destination.Name;
                // destinationViewModel.Created = destination.Created;
                // destinationViewModel.Updated = destination.Updated;
                // destinationViewModel.TravelDate = destination.TravelDate;
                destinationViewModel.TravelDestinationId = destination.TravelDestinationId;

                destinationViewModels.Add(destinationViewModel);
            }

            return destinationViewModels;
        }

        // GET api/TravelDestinations/5
        [HttpGet("{id}", Name = "GetTravelDestination")]
        public IActionResult Get(int id)
        {
            var item = new TravelCountdownApi.Model.TravelDestination();
            item.Name = "Grekland";

            if(item == null)
            {
                return NotFound();
            }

            return new OkObjectResult(item);
        }

        // POST api/TravelDestinations
        [HttpPost]
        public IActionResult Post([FromBody]TravelCountdownApi.Model.TravelDestination travelDestination)
        {
            if(travelDestination == null)
            {
                return BadRequest();
            }

            var m = travelDestination;

            return CreatedAtRoute("GetTravelDestination", new { id = travelDestination.TravelDestinationId, travelDestination});
        }

        public void Post([FromBody]string val)
        {
            var m = val;
        }

        // PUT api/TravelDestinations/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/TravelDestinations/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
