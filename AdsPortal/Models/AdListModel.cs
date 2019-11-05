using AdsPortal.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdsPortal.Models
{
    public class AdListModel
    {
        public List<Ad> Ads { get; set; }

        public Category Category { get; set; }
    }
}
