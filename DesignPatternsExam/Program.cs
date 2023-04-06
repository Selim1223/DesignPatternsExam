using DesignPatternsExam;

internal class Program
{
    static void Main(string[] args)
    {

        /// Pattern Bridge
        //Console.WriteLine("creation d'un contrat entre une société de transports et la société de Taxi Taxi Drivor");
        //ContratSociétéTransports contrat = new SociétéTaxiDrivor(new TaxiDrivorContrat());
        //Console.WriteLine("valeurs saisies : Société X et taxi drivor");
        //contrat.InfosContrat("Société X", "taxi drivor");
        //contrat.Affiche();
        //Console.WriteLine(contrat.GenereContrat());

        //Console.WriteLine("creation d'un contrat entre une société de transports et la société de Taxi Vroum Taxi");
        //contrat = new SociétéVroumTaxi(new VroumTaxiContrat());
        //Console.WriteLine("Valeurs saisies : Société X et vroum taxi");
        //contrat.InfosContrat("Société X", "vroum taxi");
        //contrat.Affiche();
        //Console.WriteLine(contrat.GenereContrat());


        //Console.WriteLine("creation d'un contrat entre une société de transports et la société de Taxi Vroum Taxi en leur donnant un contrat destiné à Taxi Drivor");
        //Console.WriteLine("affichage de l'erreur :");
        //contrat = new SociétéVroumTaxi(new TaxiDrivorContrat());
        //Console.WriteLine("Valeurs saisies : Société X et taxi drivor");
        //contrat.InfosContrat("Société X", "taxi drivor");
        //contrat.Affiche();
        //Console.WriteLine(contrat.GenereContrat());

        ///Pattern Observer
        //Console.WriteLine("avis de base");
        //Avis avis = new Avis();
        //VueAvisClient vueAvisClient = new VueAvisClient(avis);
        //Console.WriteLine("ajout de l'avis d'un client");
        //avis.Ajoute(vueAvisClient);
        //Console.WriteLine("changement de la note à 8");
        //avis.setNote(8);
        //Console.WriteLine("changement de la description");
        //avis.setDescription("Belle chambre");
        //Console.WriteLine("changement de la note, de la description et de la recommandation");
        //avis.setNote(4);
        //avis.setDescription("chambre dans un état pas terrible");
        //avis.setReccomandationChambre("Je ne recommande pas cette chambre");
        //Console.WriteLine("retrait de l'avis d'un client");
        //avis.Retire(vueAvisClient);

        ///Pattern Decorator
        VueOutils vueOutil = new VueOutils();
        NomOutil nomOutil = new NomOutil(vueOutil, "Marteau");
        MarqueOutil marqueOutil = new MarqueOutil(nomOutil, "Bosh");
        BoiteAOutils vueBoiteAOutils = marqueOutil;
        vueBoiteAOutils.Possede();



    }
}
