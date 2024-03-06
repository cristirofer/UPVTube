using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization() { }

        public Visualization(DateTime vDate, Content c, Member m) : this()
        {
            this.VisualizationDate = vDate;
            this.Content = c;
            this.Member = m;
        }
    }
}
