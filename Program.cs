using AppPaiements;

class Program
{
    static void Main(string[] args)
    {
        // On crée un nouvel utilisateur
        Utilisateur utilisateur = new Utilisateur("Abdo");

        // On ajoute des paiements à l'utilisateur
        CarteCredit paiementCarte = new CarteCredit(200.0, "Achat d'ordinateur", 98765432);
        Paypal paiementPaypal = new Paypal(100.0, "Achat de logiciels", "abdo@gmail.com");

        // On les ajoute dans la liste de l'utilisateur
        utilisateur.AjouterPaiement(paiementCarte);
        utilisateur.AjouterPaiement(paiementPaypal);

        // On montre les informations de l'utilisateur
        utilisateur.Afficher();

        // Maintenant, on va montrer les détails de chaque paiement
        Console.WriteLine("Voici les détails des paiements :");
        foreach (Paiement paiement in utilisateur.listePaiements)
        {
            paiement.AfficherDetails(); // Affiche les infos de chaque paiement
        }
    }
}
