using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {

        public List<Customer> GetCustomers()
        {
            List<Customer> list = new List<Customer>();
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand("Select * from [Customers]", con);
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Customer c = new Customer();
                    c.Id = (int)r["Id"];
                    c.Name = r["Name"].ToString();
                    c.Surname = r["Surname"].ToString();
                    c.Year = (int)r["Year"];
                    list.Add(c);
                }
            }
            return list;
        }
        /*public List<Order>GetOrders(int Id)
        {
            List<Order> list = new List<Order>();
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                 SqlCommand com = new SqlCommand("Select * from [Order] where Id_Customers =@Id", con);
                 com.Parameters.Add(new SqlParameter("@id", Id));
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Order or = new Order();
                    or.Id = (int)r["Id"];
                    or.Title = r["Title"].ToString();
                    or.Id_Customers = (int)r["Id_Customers"];
                    or.Price = (int)r["Price"];
                    or.Count = (int)r["Count"];
                    list.Add(or);
                }
            }
            return list;
        }*/
        public List<Order> GetOrders(int Id)
        {
            List<Order> list = new List<Order>();
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand("Select * from Order where Id_Customers = @Id", con);
                com.Parameters.Add(new SqlParameter("@id", Id));
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Order o = new Order();
                    o.Id = (int)r["Id"];
                    o.Title = r["Title"].ToString();
                    o.Id_Customers = (int)r["Id_Customers"];
                    o.Price = (int)r["Price"];
                    o.Count = (int)r["Count"];
                    list.Add(o);
                }
            }
            return list;
        }
    }
}