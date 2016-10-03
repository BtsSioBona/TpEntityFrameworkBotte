using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{

    public class Dossier
    {
        public String NomPatient { get; set; }
        public String PrenomPatient { get; set; }
        public DateTime DateNaissancePatient { get; set; }
        private List<Prestation> mesPrestations { get; }

        // Constructeur de la classe Dossier
        public Dossier(String unNomPatient, String unPrenomPatient, DateTime uneDateNaissancePatient)
        {
            this.NomPatient = unNomPatient;
            this.PrenomPatient = unPrenomPatient;
            this.DateNaissancePatient = uneDateNaissancePatient;

            this.mesPrestations = new List<Prestation>();
        }

        // Avec une prestation
        public Dossier(String unNomPatient, String unPrenomPatient, DateTime uneDateNaissancePatient, Prestation unePrestation)
        {
            this.NomPatient = unNomPatient;
            this.PrenomPatient = unPrenomPatient;
            this.DateNaissancePatient = uneDateNaissancePatient;

            this.mesPrestations = new List<Prestation>();
            this.mesPrestations.Add(unePrestation);
        }


        // Avec une liste de prestation
        public Dossier(String unNomPatient, String unPrenomPatient, DateTime uneDateNaissancePatient, List<Prestation> lesPretations)
        {
            this.NomPatient = unNomPatient;
            this.PrenomPatient = unPrenomPatient;
            this.DateNaissancePatient = uneDateNaissancePatient;

            this.mesPrestations = new List<Prestation>();
            this.mesPrestations.AddRange(lesPretations);
        }

        // Permet d'ajouter une prestation au dossier
        public void ajoutePrestation(String unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            this.mesPrestations.Add(new Prestation(unLibelle, uneDate, unIntervenant));
        }

        // Retourne le nombre de prestations externe réalisées pour le dossier
        public int getNbPrestationsExternes()
        {
            int i = 0;

            foreach(Prestation unePrestations in this.mesPrestations)
            {
                if(unePrestations.I_Intervenant is IntervenantExterne)
                {
                    i++;
                }
            }

            return i;
        }

        // Retourne le nombre de prestations réalisées pour le dossier
        public int getNbPrestations()
        {
            return this.mesPrestations.Count();
        }

        /* Retourne le nombre de jours de soins comptabilisés pour le dossier. Il ne s'agit pas ici de déterminer 
        Le nombre de prestations attachées à un dossier, mais le nombre de jours pour lesquels au moins
        une prestation a été réalisée */

        public int getNbJoursSoins()
        {

            List<DateTime> tempDate = new List<DateTime>();

            foreach(Prestation unePrestation in this.mesPrestations)
            {
                if(!(tempDate.Contains(unePrestation.DateSoin)))
                {
                    tempDate.Add(unePrestation.DateSoin);
                }
            }

            return tempDate.Count();
            
        }

        public override string ToString()
        {
            return "Dossier | Nom : " + this.NomPatient + " / Prenom : " + this.PrenomPatient + " / Date de naissance : " + this.DateNaissancePatient.ToString();
        }


    }
}
