using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTeamStats.Models
{
    public class CustomContributor
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public List<string> Commits { get; set; }

        public CustomContributor(string Name, string Email, string Message, List<string> Commits)
        {
            this.Name = Name;
            this.Email = Email;
            this.Message = Message;
            this.Commits = Commits;
        }
    }
}
