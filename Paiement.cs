using System;

namespace AppPaiements
{
    // Classe abstraite Paiement
    public abstract class Paiement
    {
        public double montant { get; set; }
        public string description { get; set; }

        // Constructeur de la classe Paiement
        public Paiement(double m, string d)
        {
            montant = m;
            description = d;
        }

        // Méthode abstraite pour afficher les détails
        public abstract void AfficherDetails();
    }
}
