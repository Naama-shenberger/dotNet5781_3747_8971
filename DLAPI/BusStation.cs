﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    /// <summary>
    /// bus station class
    /// </summary>
    public class BusStation
    {
        /// <summary>
        /// get and set
        /// </summary>
        public bool Active { get; set; }//status of a bus line whether it is active or not
        public string BusStationKey { get; set; }//code Station
        public string StationAddress { get; set; }//Station Address;
        public string StationName { get; set; }//Station Name
        public double Latitude { get; set; }//Latitude
        public double Longitude { get; set; }//Longitude
        /// <summary>
        /// override of ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Bus Station Key:{0}\nStation Address:{1}\nStation Name: {2}\n Landmark:\nLatitude-{3} Longitude-{4}\n", BusStationKey, StationAddress, StationName, Latitude, Longitude);
        }
                

    }
}
