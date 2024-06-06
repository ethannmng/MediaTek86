using System.Windows.Forms;

namespace MediaTek86.view.assets
{
    /// <summary>
    /// Classe qui gère les notifications Windows
    /// </summary>
    public static class NotificationIcon
    {
        /// <summary>
        /// Icône de notification
        /// </summary>
        private static NotifyIcon notifyIcon;

        /// <summary>
        /// Initialisation des notifications du bureau
        /// </summary>
        public static void InitNotifyIcon()
        {
            notifyIcon = new NotifyIcon();

            notifyIcon.Icon = Properties.Resources.MEDIATEK86_ICO;
            notifyIcon.Text = "Mediatek86 - Centre de notification";
            notifyIcon.Visible = true;
        }

        /// <summary>
        /// Fonction qui permet d'afficher une notification Windows
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        public static void NotifyWindows(string title, string message)
        {
            notifyIcon.ShowBalloonTip(5000, title, message, ToolTipIcon.None);
        }
    }
}
