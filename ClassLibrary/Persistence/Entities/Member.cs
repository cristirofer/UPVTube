﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Member
    {
        public string Email
        {
            get;
            set;
        }

        public string FullName
        {
            get; 
            set; 
        }
        [Key]
        public string Nick
        {
            get;
            set;
        }

        public DateTime LastAccessDate
        {
            get; 
            set; 
        }

        public string Password
        {   
            get;
            set;
        }
        public virtual ICollection<Member> SubscribedTo {
            get;
            set;
        }

        public virtual ICollection<Member> Subscriptors {
            get; set;
        }

        public virtual ICollection<Evaluation> Evaluations {
            get;
            set;
        }

        public virtual ICollection<Visualization> Visualizations {
            get;
            set;
        }

        public virtual ICollection<Comment> Comments {
            get;
            set;
        }

        public virtual ICollection<Content> Contents {
            get;
            set;
        }

        public void AddContent(Content c) {
            Contents.Add(c);
            
        }
    }
}
