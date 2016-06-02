using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibGit2Sharp;

namespace SharpFlow.Models
{
    public class JsonCommit
    {
        public string id { get; set; }
        public string displayId { get; set; }
        public JsonAuthor author { get; set; }
        public double authorTimestamp { get; set; }
        public string message { get; set; }
        public JsonReference[] parents { get; set; }

        public JsonCommit(Commit c)
        {
            id = c.Sha;
            displayId = c.Sha.Substring(0, 7);
            author = new JsonAuthor(c.Author);
            authorTimestamp = DateTimeToUnixTimestamp(c.Author.When);
            message = c.Message;
            parents = c.Parents.Select(p => new JsonReference(p.Sha, p.Sha.Substring(0, 7))).ToArray();
        }

        private static double DateTimeToUnixTimestamp(DateTimeOffset dateTime)
        {
            return (dateTime.UtcDateTime - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        }
    }
}