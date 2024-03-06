using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        public string Text { get; set; }
        public DateTime WritingDate { get; set; }

        [Required]
        public virtual Content Content { get; set; }
        [Required]
        public virtual Member Writer { get; set; }

        public int Id { get; set; }
    }
}
