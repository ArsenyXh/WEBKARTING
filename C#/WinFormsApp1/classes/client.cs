using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.classes
{
    public class client
    {
        [Key]
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
   
        public override string ToString()
        {
            return this.id.ToString() + " " + this.first_name;
        }
    }
}
