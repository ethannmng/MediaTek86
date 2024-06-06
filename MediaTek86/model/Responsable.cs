namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier liée à la table Responsable
    /// </summary>
    class Responsable
    {
        public string Login { get; }
        public string Pwd { get; }

        /// <summary>
        /// Valorisation des propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
