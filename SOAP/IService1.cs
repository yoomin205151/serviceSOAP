using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        DataSet SP_LISTARPRODUCTO();

        [OperationContract]
        void SP_INSERTARPRODUCTO(Producto prod);

        [OperationContract]
        void SP_ACTUALIZARPRODUCTO(Producto prod);

        [OperationContract]
        void SP_ELIMINARPRODUCTO(Producto prod);

        [OperationContract]
        DataSet SP_BUSCARPRODUCTO(Producto prod);

    }

    public class Producto
    {
        private int _id;
        [DataMember]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _detail;
        [DataMember]
        public string detail
        {

            get { return _detail; }
            set { _detail = value; }

        }

        private int _quantity;
        [DataMember]
        public int quantity
        {

            get { return _quantity; }
            set { _quantity = value; }

        }

        private double _price;
        [DataMember]
        public double price
        {

            get { return _price; }
            set { _price = value; }
        }

        private DateTime _dates;
        [DataMember]
        public DateTime dates
        {
            get { return _dates; }
            set { _dates = value; }
        }
    }
}
