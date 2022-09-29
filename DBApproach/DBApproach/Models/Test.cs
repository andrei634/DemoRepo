using System;
using System.Collections.Generic;

namespace DBApproach.Models
{
    public partial class Test
    {
        public Test()
        {
            Scores = new HashSet<Score>();
        }

        public string Testid { get; set; } = null!;

        public virtual ICollection<Score> Scores { get; set; }
    }
}
