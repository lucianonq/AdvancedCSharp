using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public partial class YoutubeApi 
    { 
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access youtube web service
                //Read the data
                //Create a list of video objects
                throw new Exception("Opps");
            }
            catch (Exception ex)
            {
                //log
                throw new YoutubeException("Could not fetch the videos from YoTtube", ex);
            }

            return new List<Video>();
        }
    }
}
