using ChesFine.Octopus.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChesFine.Octopus.Web.Areas.Admin.Models
{
    public class ThemeQueryModel:QueryBaseModel
    {
        public string Name { get; set; }

        public string Resume { get; set; }
    }
}