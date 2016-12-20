using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.interfaces
{
    public interface IinvoiceHeader
    {
        int Id { get; set; }

        string InvoiceCode { get; set; }

        string InvoiceDate { get; set; }

        IList<IInviceLine> Lines { get; set; }
        
    }



    public interface ICrud
    {
        void Add();
        void Update();

        void Delete();
    }


    public abstract class InvoiceBase:IinvoiceHeader
    {
        private IList<IInviceLine> _lines = new List<IInviceLine>();
        public int Id { get; set; }
        public string InvoiceCode { get; set; }

        public string InvoiceDate { get; set; }

        public IList<IInviceLine> Lines
        {
           get { return _lines; }
            set { _lines = value; }
        }

        public abstract void Add();
        public abstract void Update();

        public abstract void Delete();
    }
    public interface IInviceLine
    {
        int Id { get; set; }
        string ItemCode { get; set; }
        float OrderedQty { get; set; }
    }
}
