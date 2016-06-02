using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibGit2Sharp;

namespace SharpFlow.Models
{
    public class LightweightRepository
    {
        public JsonBranchCollection branches { get; set; }
        public JsonTagsCollection tags { get; set; }
        public JsonCommitsCollection[] commits { get; set; }

        public LightweightRepository(Repository repo)
        {
            branches = new JsonBranchCollection(repo.Branches);
            tags = new JsonTagsCollection(repo.Tags);
            commits = repo.Branches.Select(b => new JsonCommitsCollection(b.Commits)).ToArray();
        }
    }
}