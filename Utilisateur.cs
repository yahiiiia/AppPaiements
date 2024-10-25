using AppPaiements;
using System;
using System.Collections.Generic;

class Utilisateur
{
    // Le nom de l'utilisateur
    public string nom;

    // La liste qui garde tous les paiements
    public List<Paiement> listePaiements;

    // Quand on crée un nouvel utilisateur
    public Utilisateur(string n)
    {
        nom = n;
        // On crée une nouvelle liste vide pour les paiements
        listePaiements = new List<Paiement>();
    }

    // Pour afficher les informations de l'utilisateur
    public void Afficher()
    {
        Console.WriteLine("Bonjour " + nom + "!");
        Console.WriteLine("Vous avez fait " + listePaiements.Count + " paiements.");

        // On met une ligne pour faire joli
        Console.WriteLine("------------------");
    }

    // Pour ajouter un nouveau paiement
    public void AjouterPaiement(Paiement p)
    {
        // On ajoute le paiement à la liste
        listePaiements.Add(p);

        // On confirme l'ajout du paiement
        Console.WriteLine("Super! Un nouveau paiement a été ajouté pour " + nom + ".");
        Console.WriteLine("-------------------");
    }
}
