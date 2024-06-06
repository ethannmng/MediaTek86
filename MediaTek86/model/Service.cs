namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier liée à la table Service
    /// </summary>
    class Service
    {
        public int Idservice { get; }
        public string Nom { get; }

        /// <summary>
        /// Valorisation des données
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Récupère juste le nom du service
        /// </summary>
        /// <returns>Nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
