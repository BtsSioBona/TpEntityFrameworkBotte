using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    public class Prestation
    {
        public String Libelle { get; set; }
        public DateTime DateSoin { get; set; }
        public Intervenant I_Intervenant { get; set; }


        // Constructeur de la classe Prestation
        public Prestation(String unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            this.Libelle = unLibelle;
            this.DateSoin = uneDate;
            this.I_Intervenant = unIntervenant;
        }
        
        /* Fonction permettant de comparer 2 prestations, la prestation courante et le paramètre unePrestation
        La comparaison porte ici sur la date de la prestations.
        Retourne 0 si la date de la prestation courante est égale à la date de la prestation UnePrestation
        retourne 1 si la date de la prestation courante est postérieur à la date de la prestation UnePrestation
        retourne -1 si la date de la prestation courante est antérieur à la date de la prestation UnePrestation
        */
        public int compareTo(Prestation unePrestation)
        {
            return this.DateSoin.CompareTo(unePrestation.DateSoin);
        }
 
    }
}
