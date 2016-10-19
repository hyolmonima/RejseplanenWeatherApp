using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace weatherApp.Models
{
  
        public class Origin
        {
            public string name { get; set; }
            public string type { get; set; }
            public string routeIdx { get; set; }
            public string time { get; set; }
            public string date { get; set; }
        }

        public class Destination
        {
            public string name { get; set; }
            public string type { get; set; }
            public string routeIdx { get; set; }
            public string time { get; set; }
            public string date { get; set; }
        }

        public class Notes
        {
            public string text { get; set; }
        }

        public class JourneyDetailRef
        {
            public string @ref { get; set; }
        }

        public class Leg
        {
            public string name { get; set; }
            public string type { get; set; }
            public Origin Origin { get; set; }
            public Destination Destination { get; set; }
            public Notes Notes { get; set; }
            public JourneyDetailRef JourneyDetailRef { get; set; }
        }

        public class Trip
        {
            public List<Leg> Leg { get; set; }
        }

        public class TripList
        {
            public string noNamespaceSchemaLocation { get; set; }
            public List<Trip> Trip { get; set; }
        }

        public class RootObject
        {
            public TripList TripList { get; set; }
        }

    }