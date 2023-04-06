using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExam
{
    public interface Observateur
    {
        public void MetAJour();
    }

    public abstract class Sujet
    {
        protected List<Observateur> avis = new List<Observateur>();

        public void Ajoute(Observateur unAvis)
        {
            this.avis.Add(unAvis);
        }

        public void Retire(Observateur unAvis)
        {
            this.avis.Remove(unAvis);
        }

        protected void Notifie()
        {
            foreach (Observateur unAvis in avis)
                unAvis.MetAJour();
        }
    }

    public class Avis : Sujet
    {
        private int note = 6;
        private string descriptionChambre = " Chambre classique";
        private string recommandationChambre =  " pas d'avis";


        public void setNote(int note)
        {
            this.note = note;
            this.Notifie();
        }

        public int getNote()
        {
            return this.note;
        }

        public void setDescription(string description)
        {
            this.descriptionChambre = description;
            this.Notifie();
        }

        public string getDescription()
        {
            return this.descriptionChambre;
        }

        public void setReccomandationChambre(string recommandation)
        {
                this.recommandationChambre = recommandation;
                this.Notifie();
        }

        public string getReccomandationChambre()
        {
            return this.recommandationChambre;
        }
    }

    public class VueAvisClient : Observateur
    {
        protected Avis avis;

        public VueAvisClient(Avis avis)
        {
            this.avis = avis;

            DonneAvis();
        }

        public void MetAJour()
        {
            DonneAvis();
        }

        public void DonneAvis()
        {
            Console.WriteLine("Note de la chambre : " + avis.getNote() + "/10 ;\nDescription de la chambre : " + avis.getDescription() + "\nRecommandation de la chambre :"+ avis.getReccomandationChambre());
        }
    }
}
