using System;
using Association;

namespace UMLCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Perso crée par l'Utilisateur
            
            Personnage p1 = new Personnage("Loriane",100, 50);
            
            Personnage p2 = new Personnage("Dupont",40, 150);

            Arme a1 = new Arme ("mitraillette", 40);
            Arme a2 = new Arme ("arc", 20);
            Arme a3 = new Arme ("epée", 20);
            Arme a4 = new Arme ("grenade", 200);

            p1.rajouterArmePortee (a1);
            p1.rajouterArmePortee (a2);
            p1.rajouterArmePortee (a3);
            p1.rajouterArmePortee (a4);

            Console.WriteLine (a1.Porteur.Nom);
            Console.WriteLine (a2.Porteur.Nom);
            p1.afficherArmesPortees();

            p1.rajouterArmeFabriquee (a4);
            p1.afficherArmesFabriquees();


            
















        }
    }
}


