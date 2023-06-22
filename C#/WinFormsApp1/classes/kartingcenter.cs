using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.classes
{
    public class kartingcenter
    {
        [Key]
        public int id { get; set; }
        public string address { get; set; }
     
        public override string ToString()
        {
            return this.id.ToString();
        }
    }
}
