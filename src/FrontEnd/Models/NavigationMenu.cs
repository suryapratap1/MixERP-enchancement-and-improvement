using MixERP.Net.Entities.Core;
using System;
using System.Collections.Generic;

namespace MixERP.Net.FrontEnd.Models
{
    [Serializable]
    public class NavigationMenu
    {
        public Menu Menu { get; set; }
        public List<NavigationMenu> Children { get; set; }
    }
}