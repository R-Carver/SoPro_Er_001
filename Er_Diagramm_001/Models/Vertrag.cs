using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Er_Diagramm_001.Models
{
    public class Vertrag
    {
        public int VertragId { get; set; }
        public string Bezeichnung { get; set; }
        public int InhaberId { get; set; }

        
    }
}