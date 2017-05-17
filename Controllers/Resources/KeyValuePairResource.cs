using System.Collections.Generic;
using System.Collections.ObjectModel;
using vega.Controllers.Resources;
using vega.Core.Models;

namespace vega.Controllers.Resources
{
    public class KeyValuePairResource
    {
        public KeyValuePairResource()
        { }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}