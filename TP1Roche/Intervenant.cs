using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    public class Intervenant
    {
    
        public String Nom { get; set; }
        public String Prenom { get; set; }
        private List<Prestation> lesPrestations;

        public Intervenant(String unNom, String unPrenom)
        {
            this.Nom = unNom;
            this.Prenom = unPrenom;

            lesPrestations = new List<Prestation>();
        }

        // Ajouter une prestation dans la colletion lesPrestations
        public void ajoutePrestation(Prestation unePrestation)
        {
            this.lesPrestations.Add(unePrestation);
        }

        public override string ToString()
        {
            return "Intervenant | Nom : " + this.Nom + " / prenom : " + this.Prenom;
        }

    }
}
