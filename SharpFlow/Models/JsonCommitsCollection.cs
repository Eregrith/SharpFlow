using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibGit2Sharp;

namespace SharpFlow.Models
{
    public class JsonCommitsCollection
    {
        public JsonCommit[] values { get; set; }

        public JsonCommitsCollection(ICommitLog commits)
        {
            values = commits.Select(c => new JsonCommit(c)).ToArray();
        }
    }
}