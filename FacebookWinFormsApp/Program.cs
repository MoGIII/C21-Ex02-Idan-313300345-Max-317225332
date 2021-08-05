// $G$ THE-001 (-22) your grade on diagrams document - 69. please see comments inside the document. 40% of your grade).
// $G$ RUL-004 (-20) Wrong zip name format / folder name format
// $G$ RUL-005 (-20) Wrong zip folder structure

namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
