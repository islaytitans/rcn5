using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace RCN5.Models
{
    public class CallToActionModel
    {
        public TextField Title { get; set; }
        public RichTextField Information { get; set; }
        public TextField Subtitle { get; set; }
        public ImageField Image { get; set; }
        public HyperLinkField Link { get; set; }
    }
}
