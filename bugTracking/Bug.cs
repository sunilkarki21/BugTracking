using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bugTracking
{
    class Bug
    {
        public int BugID { get; set; }
        public int ProjectTitle { get; set; }
        public string BugTitle { get; set; }
        public string BugDescription { get; set; }
        public string ReportDate { get; set; }
        public Image BugImage { get; set; }
        public string ImagePath { get; set; }
        public int Addedby { get; set; }
    }
}
