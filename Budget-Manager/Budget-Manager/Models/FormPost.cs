using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LyftRecorder.Models {
    public class FormPost {
        public bool PassengerCancelled { get; set; }
        public bool DriverCancelled { get; set; }
        public decimal RidePrice { get; set; }
        public decimal Tips { get; set; }
        public decimal RideEarnings { get; set; }
        public DateTime RideDuration { get; set; }
        public DateTime PickupTime { get; set; }
        public DateTime DropOffTime { get; set; }
        public decimal RideDistance { get; set; }
        public bool PostSuccess { get; set; }

        public IList<FormPost> Results { get; set; }
    }
}
