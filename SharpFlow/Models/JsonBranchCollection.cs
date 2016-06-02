using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibGit2Sharp;

namespace SharpFlow.Models
{
    public class JsonBranchCollection
    {
        public JsonReference[] values { get; set; }

        public JsonBranchCollection(BranchCollection branches)
        {
            values = branches.Select(b => new JsonReference(b.UpstreamBranchCanonicalName, b.FriendlyName, b.Tip.Sha)).ToArray();
        }
    }
}