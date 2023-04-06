using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExam
{
    public interface ContratTaxi
    {
        public void DemandeSignatureContrat();
    }
    public class TaxiDrivorContrat : ContratTaxi
    {
        public void DemandeSignatureContrat()
        {
            Console.WriteLine("Demande de signatures du contrats entre les 2 parties (la société de transports et la socité taxi drivor) : ");
        }

    }
    public class VroumTaxiContrat : ContratTaxi
    {
        public void DemandeSignatureContrat()
        {
            Console.WriteLine("Demande de signatures du contrats entre les 2 parties (la société de transports et la socité vroum taxi) : ");
        }

    }

    abstract public class ContratSociétéTransports
    {
        protected string nomSocieteTransport;
        protected string nomSociétéTaxi;
        protected ContratTaxi contrat;

        protected ContratSociétéTransports(ContratTaxi contrat)
        {
            this.contrat = contrat;
        }

        public void Affiche()
        {
            contrat.DemandeSignatureContrat();
        }

        public string GenereContrat()
        {
            if (this.ControleSociete())
                return "Voici votre signature numérique unique : " + this.CreerSignatureNumeriqueUnique();
            return "contrat refusé : la société de transports a envoyé le mauvais contrat ";
        }

        public void InfosContrat(string nomSocieteTransport, string nomSociétéTaxi)
        {
            this.nomSocieteTransport = nomSocieteTransport;
            this.nomSociétéTaxi = nomSociétéTaxi;
        }

        abstract public bool ControleSociete();

        private string CreerSignatureNumeriqueUnique()
        {
            string uniqueSignature = "";

            // Générer 2 lettres aléatoires
            Random random = new Random();
            char c1 = (char)random.Next('A', 'Z' + 1);
            char c2 = (char)random.Next('A', 'Z' + 1);
            uniqueSignature += c1.ToString() + c2.ToString();

            // Générer 3 chiffres aléatoires
            int num1 = random.Next(0, 10);
            int num2 = random.Next(0, 10);
            int num3 = random.Next(0, 10);
            uniqueSignature += num1.ToString() + num2.ToString() + num3.ToString();

            // Générer 2 lettres aléatoires
            char c3 = (char)random.Next('A', 'Z' + 1);
            char c4 = (char)random.Next('A', 'Z' + 1);
            uniqueSignature += c3.ToString() + c4.ToString();

            return uniqueSignature;
        }
    }
    public class SociétéTaxiDrivor : ContratSociétéTransports
    {
        public SociétéTaxiDrivor(ContratTaxi contrat) : base(contrat)
        {

        }

        public override bool ControleSociete()
        {
            return this.nomSociétéTaxi == "taxi drivor";
        }
    }

    public class SociétéVroumTaxi : ContratSociétéTransports
    {
        public SociétéVroumTaxi(ContratTaxi contrat) : base(contrat)
        {

        }

        public override bool ControleSociete()
        {
            return this.nomSociétéTaxi == "vroum taxi";
        }
    }
}
