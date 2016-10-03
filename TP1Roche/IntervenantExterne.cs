using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    public class IntervenantExterne : Intervenant
    {

        public String Specialite { get; set; }
        public String Adresse { get; set; }
        public String Tel { get; set; }


        // Constructeur de la classe intervenantExterne
        public IntervenantExterne(String unNom, String unPrenom, String uneSpecialite, String uneAdresse, String unTel):base(unNom, unPrenom)
        {
            this.Specialite = uneSpecialite;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Adresse = uneAdresse;
            this.Tel = unTel;
        }


    }
}
