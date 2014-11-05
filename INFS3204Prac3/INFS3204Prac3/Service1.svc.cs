using System;
using System.Web;
using System.Web.Services;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Web.Hosting;

namespace INFS3204Prac3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static readonly string StockDBFilename = "Stock.txt";
        public static readonly string StoreDBFilename = "Store.txt";

        public void SaveStoreToFile(Store store)
        {
            var db = GetDbContext(StoreDBFilename);

            // If any user with the username exists return
            if (db.Any(x => x["ID"].ToString() == store.ID))
            {
                // the store already exists!
                return;
            }

            dynamic newStore = new JObject();
            newStore.ID = store.ID;
            newStore.name = store.name;
            newStore.branchNO = store.branchNO;
            newStore.address = store.address;
            newStore.phoneNumber = store.phoneNumber;

            db.Add(newStore);

            SaveDbChanges(StoreDBFilename, db);
        }

        private void SaveStockToFile(Stock stock)
        {
            var db = GetDbContext(StockDBFilename);

            dynamic newStock = new JObject();
            newStock.name = stock.name;
            newStock.isDiscontinued = stock.isDiscontinued;
            newStock.productionDate = stock.productionDate;
            newStock.StoreID = stock.Store.ID;

            db.Add(newStock);

            SaveDbChanges(StockDBFilename, db);
        }

        public bool SaveInfo(Stock stock)
        {
            try
            {
                SaveStoreToFile(stock.Store);
                SaveStockToFile(stock);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void SaveDbChanges(string filename, JArray db)
        {
            var path = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, filename);

            using(FileStream file = new FileStream(path, FileMode.Truncate))
            {
                using(StreamWriter writer = new StreamWriter(file))
                {
                    writer.Write(db.ToString());
                }
            }
        }

        private JArray GetDbContext(string filename)
        {
            // Open or Create our json encoded flat file database
            var path = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, filename);

            string text = "";

            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    text = reader.ReadToEnd();
                }
            }

            // If file is empty use an empty json array
            if (text.Count() == 0)
            {
                text = "[]";
            }

            // Parse our json encoded database in a json object
            return JArray.Parse(text);
        }

        public Store GetStore(string ID)
        {
            // Parse our json encoded database in a json object
            var db = GetDbContext(StoreDBFilename);

            var jsonObj = db.Where(x => x["ID"].ToString() == ID).SingleOrDefault();

            if (jsonObj != null)
            {
                return jsonObj.ToObject<Store>();
            }

            return null;
        }

        public IEnumerable<Store> GetAllStores(string name)
        {
            var stockDb = GetDbContext(StockDBFilename);

            var stocks = stockDb.Where(x => x["name"].ToString() == name)
                                .Where(x => !x["isDiscontinued"].ToObject<Boolean>());

            if (stocks.Count() == 0)
            {
                return null;
            }

            return stocks.Select(x => GetStore(x["StoreID"].ToString()));
        }
    }

}
