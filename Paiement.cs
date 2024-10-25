public abstract class Paiement
{
    public double montant { get; set; }
    public string description { get; set; }

    public Paiement(double m, string d)
    {
        montant = m;
        description = d;
    }

    public abstract void AfficherDetails();
}
