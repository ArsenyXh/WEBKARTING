using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.classes
{
    public class application
    {
        [Key]
        public int id { get; set; }
        public string type { get; set; }
        public DateTime timestart { get; set; }
        public DateTime timeend { get; set; }
        public int price { get; set; }
        public string status { get; set; }
        public int? idworker { get; set; }
        public int? idkart { get; set; }
        public int? idequipment { get; set; }
        public int idcenter { get; set; }
        public string idclient { get; set; }
        
        public override string ToString()
        {
            return this.id.ToString();
        }
    }
}
