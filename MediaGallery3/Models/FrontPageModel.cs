using MediaGallery3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery3.Models
{
    public class FrontPageModel
    {
        public IList<MediaItem> NewPhotos { get; set; }
        public IList<MediaItem> PopularPhotos { get; set; }
    }
}
