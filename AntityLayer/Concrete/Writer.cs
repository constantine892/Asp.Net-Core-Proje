using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public int WriterName { get; set; }
        public int WriterAboud { get; set; }
        public int WriterImage { get; set; }
        public int WriterMail { get; set; }
        public int WriterPaswsword { get; set; }

    }
}
