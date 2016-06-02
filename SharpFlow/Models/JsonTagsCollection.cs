using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibGit2Sharp;

namespace SharpFlow.Models
{
    public class JsonTagsCollection
    {
        public JsonReference[] values { get; set; }

        public JsonTagsCollection(TagCollection tags)
        {
            values = tags.Select(t => new JsonReference(t.CanonicalName, t.FriendlyName, t.Target.Sha)).ToArray();
        }
    }
}