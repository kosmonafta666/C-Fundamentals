namespace SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Participant
    {
        public string Name { get; set; }
        public HashSet<string> Awards { get; set; }
    }
}
