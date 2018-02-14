using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zadatak611
{
    class Program
    {
        public static string PATH = "osobe.xml";
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        static void Main(string[] args)
        {
            try
            {
                CreateXML();
                Console.WriteLine("XML CREATED!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
        }

        public static DataTable GetKupacData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select top 10 * from kupac", cs);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        private static void CreateXML()
        {
            XmlWriter writer = CreateWriter();

            writer.WriteStartDocument();

            writer.WriteStartElement("ArhivaKupaca");

            foreach (DataRow item in GetKupacData().Rows)
            {
                writer.WriteStartElement("Kupac");
                writer.WriteAttributeString("IDKupac", item["IDKupac"].ToString());
                writer.WriteAttributeString("GradID", item["GradID"].ToString());

                writer.WriteElementString("Ime", item["Ime"].ToString());
                writer.WriteElementString("Prezime", item["Prezime"].ToString());

                writer.WriteStartElement("Kontakt");
                writer.WriteAttributeString("email", item["Email"].ToString());
                writer.WriteAttributeString("telefon", item["Telefon"].ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();


            }

            writer.WriteEndElement();
            writer.Close();

        }

        private static XmlWriter CreateWriter()
        {
            XmlWriterSettings set = new XmlWriterSettings();
            set.Indent = true;

            return XmlWriter.Create(PATH, set);
        }
    }
}
