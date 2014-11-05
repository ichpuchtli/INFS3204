using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace INFS3204Prac3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Boolean SaveInfo(Stock stock);

        [OperationContract]
        Store GetStore(String ID);

        [OperationContract]
        IEnumerable<Store> GetAllStores(String name);
    }

    [DataContract]
    public class Store
    {
        [DataMember]
        public String ID { get; set; }

        [DataMember]
        public String name { get; set; }

        [DataMember]
        public int branchNO { get; set; }

        [DataMember]
        public String address { get; set; }

        [DataMember]
        public int phoneNumber { get; set; }
    }

    [DataContract]
    public class Stock
    {
        [DataMember]
        public String name { get; set; }

        [DataMember]
        public DateTime productionDate { get; set; }
        
        [DataMember]
        public Boolean isDiscontinued { get; set; }

        [DataMember]
        public Store Store { get; set; }
    }
}
