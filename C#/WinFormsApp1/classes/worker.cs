using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.classes
{
    public class worker 
    {
        [Key]
        public int id { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string telephone { get; set; }
        public string password { get; set; }
    
        public override string ToString()
        {
            return this.id.ToString() + " " + this.name;
        }
    }
}
