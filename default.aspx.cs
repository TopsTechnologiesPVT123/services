using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ServiceOrientedApplication
{
    public partial class _default : System.Web.UI.Page
    {
        public class person
        {
            public int age;
            public string name;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod()]
        public static List<string> methodCall()
        {
            List<string> str = new List<string>();
            str.Add("a1");
            str.Add("a2");
            str.Add("a3");
            str.Add("a4");
            return str;
        }

        [WebMethod()]
        public static List<person> getPerson()
        {
            List<person> personObj = new List<person>();
            personObj.Add(new person() { age = 10, name = "abc" });
            personObj.Add(new person() { age = 10, name = "abc" });
            personObj.Add(new person() { age = 10, name = "abc" });
            personObj.Add(new person() { age = 10, name = "abc" });
            return personObj;
        }

        [WebMethod()]
        public static string getAll()
        {
            JavaScriptSerializer TheSerializer = new JavaScriptSerializer();

            //optional: you can create your own custom converter
            //TheSerializer.RegisterConverters(new JavaScriptConverter[] { new person() });
            List<person> personObj = new List<person>();
            personObj.Add(new person() { age = 10, name = "abc" });
            personObj.Add(new person() { age = 10, name = "abc" });
            personObj.Add(new person() { age = 10, name = "abc" });
            personObj.Add(new person() { age = 10, name = "abc" });
            var products = personObj.ToList();

            var TheJson = TheSerializer.Serialize(products);

            return TheJson;
        }

        [WebMethod()]
        public static string login(string uname, string password)
        {
            JavaScriptSerializer TheSerializer = new JavaScriptSerializer();

            responseClass res = new responseClass();

            if (uname == "a" && password == "123")
            {

                res.status= "1";
                res.message = "done";



            }
            else
            {
                res.status = "-1";
                res.message = "err";
            }
            var data = res;

            var TheJson = TheSerializer.Serialize(data);
            return TheJson;
        }

        public class responseClass {
            public string status { get; set; }
            public string message { get; set; }
        }


        
    }
}