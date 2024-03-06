using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Services;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Content() {
            Subjects = new List<Subject>();
            Visualizations = new List<Visualization>();
            Comments = new List<Comment>();
        }
        public Content(string ContentURI, string Description, bool IsPublic, string Title, DateTime UploadDate, Member Owner) : this()
        {
            this.ContentURI = ContentURI;
            this.Description = Description;
            this.IsPublic = IsPublic;
            this.Title = Title;
            this.UploadDate = UploadDate;
            this.Owner = Owner;

            this.Authorized = Authorized.Yes;
            if (Domains.IsStudentDomain(Owner.Email)) this.Authorized = Authorized.Pending;
        }
    }
}
