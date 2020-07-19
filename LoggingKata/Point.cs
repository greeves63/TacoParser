using System;

namespace LoggingKata
{
    public struct Point
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Point (double lon, double lat)
        {
            Longitude = lon;
            Latitude = lat;
        }
    }
}