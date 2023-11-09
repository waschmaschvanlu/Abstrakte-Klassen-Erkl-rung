



Auto // Auto von Unten wird geladen

auto1 = new Auto(); // eine Neue Klasse Wird erstellt --> Fahrzeug --> Auto
auto1.Name = "BMW"; // in Fahrzeug wird der Name gesetzt
auto1.Drive(); // Auto.Drive() wird ausgeführt


Fahrrad // Fahrrad wird Unten geladen
    fahrrad1 = new Fahrrad(); // eine Neue Klasse wird erstellt --> Fahrzeug --> Fahrrad
fahrrad1.Name = "BMX"; // Fahrrad bekommt den namen BMX (wird in Fahrzeug gemacht)
fahrrad1.Drive();  // Fahrrad.Drive() wird ausgeführt!


// was abstract (zeile 25) macht ist, das die Hauptklasse Fahrzeug NICHT Definiert werden kann, hier ist ein beispiel dafür:
   // Fahrzeug meinauto1 = new Fahrzeug(); 
// die Obere zeile Wird nicht ausgeführt Weil sonst das Programm nicht Startet! entkommentier diese zeile (die 2 // weg) und dann kannst du das selber sehen das dein IDE (dein Visual Studio) einen Fehler ausgibt weil Fahrzeug Abtract ist,





public abstract class Fahrzeug{ // Erstellt die Abstrakte Klasse Fahrzeug

public string Name { get; set; } // Erstellt eine Variable Name, welche in allen Unterklassen Verwendet wird

    public abstract void Drive(); // erstellt eine Drive() Funktion welche den namenausgibt (in den Unterklassen!)
}


public class Auto:Fahrzeug // unterKlasse Fahrzeug wird erstellt
{

    public override void Drive() // Drive Funktion wird Definiert
    {
        Console.WriteLine("Das Auto ist ein " + Name); // Name von Fahrzeug wird benutzt!
    }


}


public class Fahrrad:Fahrzeug // unterKlasse Fahrrad wird erstellt!
{
    public override void Drive() // Drive Funktion wird definiert!
    {
        Console.WriteLine("Das Fahrrad ist ein " + Name); // Name von Fahrzeug wird Benutzt!
    }

}





