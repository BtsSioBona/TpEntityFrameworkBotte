using System;
using System.Collections.Generic;
using System.Xml;
using classesMetier;

namespace utilitaire
{
    public abstract class XMLToObject
    {


        // Retourne un dossier
        public static Dossier XMLToDossier(XmlNode dossier){

            return new Dossier(dossier.ChildNodes[0].InnerXml, dossier.ChildNodes[1].InnerXml, XMLToDateTime(dossier.ChildNodes[2]));

        }

        // Retourne une prestation
        public static Prestation XMLToPrestation(XmlNode prestation)
        {

            return new Prestation(prestation.ChildNodes[0].InnerXml, XMLToDateTime(prestation), XMLToIntervenant(prestation));

        }

        // Retourne un intervenant
        public static Intervenant XMLToIntervenant(XmlNode intervenant)
        {

            return new Intervenant(intervenant.ChildNodes[0].InnerXml, intervenant.ChildNodes[1].InnerXml);

        }

        // Retourne une liste de dossier(s)
        public static List<Dossier> XMlToDossiers(XmlNodeList dossier)
        {
            List<Dossier> tempDossiers = new List<Dossier>();

            for (int i = 0; i < dossier.Count; i++)     // Lecture des dossier(s)
            {
                tempDossiers.Add(XMLToDossier(dossier[i]));
            }

            return tempDossiers;
        }

        // Retourne une liste d'intervenant(s)
        public static List<Intervenant> XMLToIntervenants(XmlNodeList intervenant)
        {
            List<Intervenant> tempIntervenant = new List<Intervenant>();

            for (int i = 0; i < intervenant.Count; i++)     // Lecture des dossier(s)
            {
                tempIntervenant.Add(XMLToIntervenant(intervenant[i]));
            }

            return tempIntervenant;
        }

        // Retourne une date
        public static DateTime XMLToDateTime(XmlNode date)
        {
            return new DateTime(Convert.ToInt32(date.ChildNodes[2].InnerXml), Convert.ToInt32(date.ChildNodes[1].InnerXml), Convert.ToInt32(date.ChildNodes[0].InnerXml), (date.ChildNodes[5] == null) ? 0 : Convert.ToInt32(date.ChildNodes[5].InnerXml), (date.ChildNodes[4] == null) ? 0 : Convert.ToInt32(date.ChildNodes[4].InnerXml), (date.ChildNodes[3] == null) ? 0 : Convert.ToInt32(date.ChildNodes[3].InnerXml));
        }


    }
}
