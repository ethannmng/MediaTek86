using System;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier liée à la table Absence
    /// </summary>
    class Absence
    {
        public Personnel Personnel { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif Motif { get; set; }

        /// <summary>
        /// Valorisation des données
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Personnel = personnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }
    }
}
