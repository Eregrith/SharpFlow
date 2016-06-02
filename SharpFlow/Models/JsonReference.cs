using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharpFlow.Models
{
    public class JsonReference
    {
        public string displayId { get; set; }
        public string latestChangeset { get; set; }
        public string id { get; set; }

        public JsonReference(string id, string displayId, string latestChangeset)
        {
            this.id = id;
            this.displayId = displayId;
            this.latestChangeset = latestChangeset;
        }

        public JsonReference(string id, string displayId)
        {
            this.id = id;
            this.displayId = displayId;
        }
    }
}