using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoutubeAPITest.Models
{
    public class Video
    {
        public string Title { get; set; } 
        public string VideoId { get; set; }
        public string ChannelName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Video(string title, string videoId, string channelName, string description, string image)
        {
            Title = title;
            VideoId = videoId;
            ChannelName = channelName;
            Description = description;
            Image = image;
        }
    }
}
