using System;//: Importe la bibliothèque de base de C# qui contient des classes fondamentales comme Object, String, Array, etc.
using System.Collections.Generic;//: Permet d'utiliser des collections génériques comme List<T>.
using System.Linq;//: Pour des fonctionnalités liées à LINQ, ce qui peut être utile pour des opérations sur des collections.
using System.Text;//: Permet d'utiliser des fonctionnalités pour manipuler des séquences de caractères.
using System.Threading.Tasks;//: Utilisé pour le traitement asynchrone avec des tâches.


namespace Cours_à_distance_05.Modeles
{
    /*internal class Coureur : Déclare une classe Coureur avec un modificateur d'accès internal.
      Le modificateur d'accès internal 
      en C# est utilisé pour rendre une classe accessible à toutes les autres classes et types situés dans le même assemblage (projet), 
      mais pas à ceux situés dans d'autres assemblages.*/
    internal class Coureur
    {
        #region Attributs

        public static List<Coureur> CollClasse = new List<Coureur>(); //public static List<Coureur> CollClasse = new List<Coureur>();: Crée une liste publique et statique pour stocker des instances de la classe Coureur.

        private string _nom; // private string _nom;: Déclare un attribut privé de type string pour stocker le nom.
        private string _prenom; //private string _prenom;: Pour stocker le prénom.
        private DateTime _dateNaissance; //private DateTime _dateNaissance;: Pour stocker la date de naissance.
        private string _sexe; //private string _sexe;: Pour stocker le sexe.
        private string _email; //private string _email;: Pour stocker l'e-mail.
        private string _numeroTelephone; //private string _numeroTelephone;: Pour stocker le numéro de téléphone.
        
        #endregion

        #region Constructeur
        public Coureur(string nom, string prenom, DateTime dateNaissance, string sexe, string email, string numeroTelephone)
        {
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
            _sexe = sexe;
            _email = email;
            _numeroTelephone = numeroTelephone;

            Coureur.CollClasse.Add(this);
        }
        #endregion

        #region Getters/Setters

        public string Nom
        {
            get { return _nom; } //Le "getter" (get { return _nom; }) va "chercher" la valeur actuelle de l'attribut privé _nom et la renvoyer à quiconque demande la propriété publique Nom.
            set { _nom = value; } //Le "setter" (set { _nom = value; }) prend une nouvelle valeur (appelée value par défaut dans C#) et l'attribue à l'attribut privé _nom.
            /*Donc, en utilisant la propriété Nom, vous pouvez à la fois lire et modifier la valeur de l'attribut privé _nom de manière contrôlée.*/
        }

        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public DateTime dateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value;}
        }

        public string sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string numeroTelephone
        {
            get { return _numeroTelephone;}
            set { _numeroTelephone = value;}
        }

        #endregion

        #region Methodes
        #endregion
    }
}
