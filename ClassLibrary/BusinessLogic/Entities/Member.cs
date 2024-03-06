using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Member {
        public Member() {
            SubscribedTo = new List<Member>();
            Subscriptors = new List<Member>();
            Comments = new List<Comment>();
            Contents = new List<Content>();
            Visualizations = new List<Visualization>();
            Evaluations = new List<Evaluation>();
        }

        public Member (string Email, string FullName, DateTime LastAccessDate, string Nick, string Password) :this() {
            this.Email = Email;
            this.FullName = FullName;
            this.LastAccessDate = LastAccessDate;
            this.Nick = Nick;
            this.Password = Password;
        }

        
    }
}
