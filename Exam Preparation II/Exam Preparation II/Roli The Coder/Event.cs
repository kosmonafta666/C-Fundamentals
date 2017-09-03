namespace Roli_The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Event
    {
        public string Name { get; set; }
        public HashSet<string> Participants { get; set; }
    }
}
