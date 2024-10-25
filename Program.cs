using System;
using AppPaiements;

class Program
{
    static void Main(string[] args)
    {
        // Créer trois instances de CarteCredit
        CarteCredit achat1 = new CarteCredit(100.0, "Achat de Livres", 12345678);
        CarteCredit achat2 = new CarteCredit(250.0, "Électronique", 87654321);
        CarteCredit achat3 = new CarteCredit(50.0, "Abonnement en Ligne", 11223344);

        // Afficher les détails de chaque paiement
        achat1.AfficherDetails();
        achat2.AfficherDetails();
        achat3.AfficherDetails();
    }
}
