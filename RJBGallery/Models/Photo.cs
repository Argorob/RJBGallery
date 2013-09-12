using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RJBGallery.Models
{
    public class Photo
    {
        public string photoName
        {
            get;
            set;
        }

        public Photo(string temp_photoName)
        {
            photoName = temp_photoName;
        }

        public Photo()
        {
        }

    }
}