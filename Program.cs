// Mon premier paiement Paypal
Paypal p1 = new Paypal(75.0, "acheter des chaussures", "yahia@gmail.com");

// Mon deuxième paiement Paypal
Paypal p2 = new Paypal(150.0, "abonnement gym", "abderrafia@gmail.com");

// Je montre les paiements
Console.WriteLine("Voici le premier paiement:");
p1.AfficherDetails();

Console.WriteLine("Voici le deuxième paiement:");
p2.AfficherDetails();

// Pour attendre avant de fermer
Console.WriteLine("Appuyez sur une touche pour terminer...");
Console.ReadKey();
