using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop.interfaces;

namespace oop
{
    public class InvoiceHeader:interfaces.InvoiceBase
    {
       
        public override void Add()
        {
            
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class InvoiceDetail:interfaces.IInviceLine
    {
       

        public int Id { get; set; }
        public string ItemCode { get; set; }

        public float OrderedQty { get; set; }


    }
}
