using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classesMetier;
using System.Xml;
using System.Configuration;
using utilitaire;

namespace TP1Roche
{
    class Program
    {

        // Variables
        List<Dossier> dossiers = new List<Dossier>();
        List<Intervenant> intervenants = new List<Intervenant>();


        static void Main(string[] args)
        {

            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(ConfigurationManager.AppSettings["urlXml"]);


            XmlElement root = xmlFile.DocumentElement;
            XmlNodeList dossier = root.GetElementsByTagName("dossier");
            XmlNodeList intervenant = root.GetElementsByTagName("intervenant");

            List<Dossier> dossiers = new List<Dossier>();
            List<Prestation> prestations = new List<Prestation>();
            List<Intervenant> intervenants = new List<Intervenant>();


            dossiers = XMLToObject.XMlToDossiers(dossier);
            intervenants = XMLToObject.XMLToIntervenants(intervenant);

            foreach (Dossier unDossier in dossiers)
            {
                Console.WriteLine(unDossier.ToString());
            }

            foreach (Intervenant unIntervenant in intervenants)
            {
                Console.WriteLine(unIntervenant.ToString());
            }


            /*
            Console.ForegroundColor = ConsoleColor.Green;
   
            readXmlFile jeuDessai = new readXmlFile(ConfigurationManager.AppSettings["urlXml"]);
            jeuDessai.load();


            // Lecture des dossiers
            foreach(Dossier dossier in jeuDessai.getDossiers())
            {
                Console.WriteLine(dossier.ToString());
            }

            // Lecture des intervenants
            foreach (Intervenant intervenant in jeuDessai.getIntervenants())
            {
                Console.WriteLine(intervenant.ToString());
            }


    */
            Console.Read();
            

        }
    }
}
