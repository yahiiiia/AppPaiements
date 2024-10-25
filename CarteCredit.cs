using System;

namespace AppPaiements
{
    // Classe CarteCredit qui hérite de Paiement
    public class CarteCredit : Paiement
    {
        // Le numéro de la carte
        public int numeroCarte;

        // Quand on crée un nouveau paiement par carte
        public CarteCredit(double m, string desc, int num) : base(m, desc)
        {
            numeroCarte = num;
        }

        // Pour montrer les détails du paiement
        public override void AfficherDetails()
        {
            Console.WriteLine("Le numéro de la carte est: " + numeroCarte);
            Console.WriteLine("Le montant est: " + montant);
            Console.WriteLine("La description est: " + description);
        }
    }
}
