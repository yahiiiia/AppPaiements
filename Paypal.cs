using AppPaiements;
using System;
using System.Reflection.Metadata;

// Mon programme de Paypal
class Paypal : Paiement
{
    // Le mail du compte Paypal
    public string email;

    // Pour créer un nouveau paiement Paypal
    public Paypal(double montant, string desc, string mail) : base(montant, desc)
    {
        email = mail;
    }

    // Pour montrer les informations du paiement
    public override void AfficherDetails()
    {
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Montant payé: " + montant + " MAD");
        Console.WriteLine("Pour quoi: " + description);
        Console.WriteLine("-----------------");  // Pour faire joli
    }
}
