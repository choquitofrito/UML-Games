namespace Association
{

    public class Personnage
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


        private int force;
        public int Force
        {
            get
            {
                return force;
            }
            set
            {
                force = value;
            }
        }


        private int stamina;
        public int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                stamina = value;
            }
        }

        // Association Porter
        public List<Arme> armesPortees = new List<Arme>();
        // Association Fabriquer
        public List<Arme> armesFabriquees = new List<Arme>();

        // constructeur
        public Personnage(string nom, int force, int stamina)
        {
            Console.WriteLine("Personnage crée");
            this.nom = nom;
            this.force = force;
            this.stamina = stamina;
        }
        // méthode pour afficher le détail du perso
        public void afficher()
        {
            Console.WriteLine(this.nom + " a " + this.force + " points de force et " + this.stamina + " de stamina");
        }

        // méthode qui rajoute une Arme au Personnage
        // on a une limitation de 3 armes
        // Renvoie false si on ne peut pas rajouter l'Arme
        public bool rajouterArmePortee(Arme arme)
        {
            if (this.armesPortees.Count() < 3)
            {
                // assoc Personnage->Arme 
                // (rajouter à la liste)
                this.armesPortees.Add(arme);
                // assoc Arme->Personnage (porter)
                arme.Porteur = this;

                return true;
            }
            else
            {
                Console.WriteLine("Vous portez déjà trop d'armes");
                return false;
            }
        }

        // méthode qui rajoute une Arme au Personnage
        // à la liste d'armes fabriquées
        public void rajouterArmeFabriquee(Arme arme)
        {
            this.armesFabriquees.Add(arme);
            arme.Fabricant = this;
        }

        public void afficherArmesPortees()
        {
            Console.WriteLine("Le personnage " + this.nom + " porte: ");
            // parcourir la liste en affichant le nom de chaque arme et sa puissance
            foreach (Arme arme in this.armesPortees)
            {
                Console.WriteLine(arme.Nom + " : " + arme.Damage);
            }

        }

        public void afficherArmesFabriquees()
        {
            Console.WriteLine("Le personnage " + this.nom + " a fabriqué: ");
            // parcourir la liste en affichant le nom de chaque arme et sa puissance
            foreach (Arme arme in this.armesFabriquees)
            {
                Console.WriteLine(arme.Nom + " : " + arme.Damage);
            }

        }

    }

}