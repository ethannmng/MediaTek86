namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier liée à la table Motif
    /// </summary>
    class Motif
    {
        public int Idmotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// Valorisation des données
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Récupère juste le nom du motif
        /// </summary>
        /// <returns>Nom du service</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
