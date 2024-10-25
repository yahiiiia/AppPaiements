using AppPaiements;
using System;
using System.Collections.Generic;

class Utilisateur
{
    // Le nom de l'utilisateur
    public string Nom { get; private set; }

    // La liste qui garde tous les paiements
    public List<Paiement> ListePaiements { get; private set; }

    // Quand on crée un nouvel utilisateur
    public Utilisateur(string nom)
    {
        Nom = nom;
        // On crée une nouvelle liste vide pour les paiements
        ListePaiements = new List<Paiement>();
    }

    // Pour afficher les informations de l'utilisateur
    public void Afficher()
    {
        Console.WriteLine($"Bonjour {Nom} !"); // Hello {Name}!
        Console.WriteLine($"Vous avez effectué {ListePaiements.Count} paiements."); // You have made {Count} payments.
        Console.WriteLine("------------------");
    }

    // Pour ajouter un nouveau paiement
    public void AjouterPaiement(Paiement paiement)
    {
        // On ajoute le paiement à la liste
        ListePaiements.Add(paiement);
        Console.WriteLine($"Génial ! Un nouveau paiement a été enregistré pour {Nom}."); // Awesome! A new payment has been recorded for {Name}.
        Console.WriteLine("-------------------");
    }

    // Pour afficher tous les paiements
    public void AfficherTousLesPaiements()
    {
        Console.WriteLine("Voici les détails de tous les paiements :"); // Here are the details of all payments:
        foreach (var paiement in ListePaiements)
        {
            paiement.AfficherDetails(); // Display the details of each payment
        }
    }
}
