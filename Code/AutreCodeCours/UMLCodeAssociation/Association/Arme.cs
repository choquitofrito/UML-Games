namespace Association
{

    public class Arme
    {

        private string nom;

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }


        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }


        // Le personnage qui porte cette Arme
        private Personnage? porteur;
        public Personnage Porteur
        {
            get
            {
                return porteur;
            }
            set
            {
                porteur = value;
            }
        }

        private Personnage? fabricant;
        public Personnage Fabricant
        {
            get
            {
                return fabricant;
            }
            set
            {
                fabricant = value;
            }
        }

        public Arme(string nom, int damage)
        {
            this.nom = nom;
            this.damage = damage;
        }
        // méthode pour afficher le détail du perso
        public void afficher()
        {
            Console.WriteLine(this.nom + " provoque " + this.damage + " points de damage");
        }


    }

}