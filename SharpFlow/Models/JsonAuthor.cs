using LibGit2Sharp;

namespace SharpFlow.Models
{
    public class JsonAuthor
    {
        public string emailAddress { get; set; }
        public string displayName { get; set; }

        public JsonAuthor(Signature author)
        {
            emailAddress = author.Email;
            displayName = author.Name;
        }
    }
}