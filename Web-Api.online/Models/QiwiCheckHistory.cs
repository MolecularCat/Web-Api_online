using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using xNet;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Web_Api.online.Data.Repositories;
using Web_Api.online.Services;

namespace Web_Api.online.Models
{
    public class QiwiCheckHistory
    {
        CookieDictionary MyCokies;

        string UA = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36 OPR/43.0.2442.991";

        HttpRequest def = new HttpRequest();

        private QiwiService _qiwiService;

        

        #region DeSerialise
        class Entity
        {
            public string ticket { get; set; }
        }

        class AuthJson
        {
            public Entity entity { get; set; }
        }
        #endregion

        #region trash
        public class Sum
        {
            public double amount { get; set; }
            public int currency { get; set; }
        }

        public class Commission
        {
            public double amount { get; set; }
            public int currency { get; set; }
        }

        public class Total
        {
            public double amount { get; set; }
            public int currency { get; set; }
        }

        public class Provider
        {
            public int id { get; set; }
            public string shortName { get; set; }
            public string longName { get; set; }
            public string logoUrl { get; set; }
            public string description { get; set; }
            public string keys { get; set; }
            public string siteUrl { get; set; }
            public List<object> extras { get; set; }
        }

        public class Source
        {
            public int id { get; set; }
            public string shortName { get; set; }
            public string longName { get; set; }
            public object logoUrl { get; set; }
            public object description { get; set; }
            public string keys { get; set; }
            public object siteUrl { get; set; }
            public List<object> extras { get; set; }
        }

        public class Features
        {
            public bool chequeReady { get; set; }
            public bool bankDocumentReady { get; set; }
            public bool regularPaymentEnabled { get; set; }
            public bool bankDocumentAvailable { get; set; }
            public bool repeatPaymentEnabled { get; set; }
            public bool favoritePaymentEnabled { get; set; }
            public bool greetingCardAttached { get; set; }
        }

        public class ServiceExtras
        {
        }

        public class View
        {
            public string title { get; set; }
            public string account { get; set; }
        }

        public class Datum
        {
            public long txnId { get; set; }
            public object personId { get; set; }
            public DateTime date { get; set; }
            public int errorCode { get; set; }
            public object error { get; set; }
            public string status { get; set; }
            public string type { get; set; }
            public string statusText { get; set; }
            public string trmTxnId { get; set; }
            public string account { get; set; }
            public Sum sum { get; set; }
            public Commission commission { get; set; }
            public Total total { get; set; }
            public Provider provider { get; set; }
            public Source source { get; set; }
            public string comment { get; set; }
            public double currencyRate { get; set; }
            public List<object> paymentExtras { get; set; }
            public Features features { get; set; }
            public ServiceExtras serviceExtras { get; set; }
            public View view { get; set; }
        }
        #endregion

        public class History
        {
            public List<Datum> data { get; set; }
            //public long nextTxnId { get; set; }
            //public DateTime nextTxnDate { get; set; }
        }

        static string DateTimeToUnixTimestamp(DateTime dateTime)
        {
            TimeSpan span = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
            return (span.TotalMilliseconds).ToString("0");
        }
    }
}