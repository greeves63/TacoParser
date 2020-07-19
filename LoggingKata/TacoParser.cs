namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                return null;
            }
            
            // - FINISHED - grab the latitude from your array at index 0

            double lat = double.Parse(cells[0]);
            // - FINISHED - grab the longitude from your array at index 1
            double lon = double.Parse(cells[1]);
            // - FINISHED - grab the name from your array at index 2
            string name = cells[2];

            // - FINISHED -Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`


            // - FINISHED -You'll need to create a TacoBell class
            // - FINISHED -that conforms to ITrackable
            Point One  = new Point();
            One.Latitude = lat;
            One.Longitude = lon;

            TacoBell taco = new TacoBell();
            taco.Name = name;
            taco.Location = One;
            
            // - FINISHED -Then, you'll need an instance of the TacoBell class
            // - FINISHED - With the name and point set correctly

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return taco;
        }
    }
}