using AppPaiements;

static void Main(string[] args)
{
    // On cree un nouvel utilisateur
    Utilisateur utilisateur = new Utilisateur("Yahia");

    // On affiche les infos de l'utilisateur
    utilisateur.Afficher();

    // On cree un paiement fictif
    Paiement paiement1 = new CarteCredit(100.0, "Achat de livre", 12345678);
    Paiement paiement2 = new Paypal(50.0, "Abonnement streaming", "yahia@gmail.com");

    // On ajoute les paiements
    utilisateur.AjouterPaiement(paiement1);
    utilisateur.AjouterPaiement(paiement2);

    // On affiche les infos de nouveau
    utilisateur.Afficher();

    // Pour attendre avant de fermer
    Console.WriteLine("Appuyez sur une touche pour terminer...");
    Console.ReadKey();
}
