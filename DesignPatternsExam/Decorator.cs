using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExam
{
    public interface BoiteAOutils
    {
        public void Possede();
    }
    abstract public class Outil : BoiteAOutils
    {
        protected BoiteAOutils outil;

        public Outil(BoiteAOutils outil)
        {
            this.outil = outil;
        }

        abstract public void Possede();
    }
    public class VueOutils : BoiteAOutils
    {
        public void Possede()
        {
            Console.WriteLine("Voici les outils de notre boite à outils");
        }
    }
    public class NomOutil : Outil
    {
        protected string categorie;

        public NomOutil(BoiteAOutils outil, string categorie) : base(outil)
        {
            this.categorie = categorie;
        }

        public override void Possede()
        {
            this.outil.Possede();
            AfficheCategorie();
        }

        protected void AfficheCategorie()
        {
            Console.WriteLine("Catégorie de l'outil : " + categorie);
        }
    }
    public class MarqueOutil : Outil
    {
        protected string marque;

        public MarqueOutil(BoiteAOutils outil, string marque) : base(outil)
        {
            this.marque = marque;
        }

        public void AfficheMarque()
        {
            Console.WriteLine("Marque de l'outil : " + marque);
        }

        public override void Possede()
        {
            this.outil.Possede();
            this.AfficheMarque();
        }
    }
}
