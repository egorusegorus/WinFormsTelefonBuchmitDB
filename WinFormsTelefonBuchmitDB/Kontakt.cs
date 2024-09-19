[Serializable]
public class Kontakt
{
    public int ID { get; set; }
    public string? Vorname { get; set; }
    public string? Nachname { get; set; }
    public string? Telefon { get; set; }
    public string? Email { get; set; }
    public DateTime Geandert { get; set; }
    public DateTime Erstellt { get; set; }


    public Kontakt() { }


    public Kontakt(string vorname, string nachname, string telefon, string email)
    {
        Vorname = vorname;
        Nachname = nachname;
        Telefon = telefon;
        Email = email;
        Geandert = DateTime.Now;
        Erstellt = DateTime.Now;
    }


    public Kontakt(string vorname, string nachname, string telefon, string email, DateTime geandert, DateTime erstellt)
    {
        Vorname = vorname;
        Nachname = nachname;
        Telefon = telefon;
        Email = email;
        Geandert = geandert;
        Erstellt = erstellt;
    }

    public override string ToString()
    {
        return $"{ID} {Vorname} {Nachname} {Telefon} {Email} {Geandert} {Erstellt}";
    }
}
