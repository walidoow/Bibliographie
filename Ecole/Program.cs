using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecole
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
    public enum Mois
    {
        JANVIER = 1,
        FEVRIER = 2,
        MARS = 3,
        AVRIL = 4,
        MAI = 5,
        JUIN = 6,
        JUILLET = 7,
        AOUT = 8,
        SEPTEMBRE = 9,
        OCTOBRE = 10,
        NOVEMBRE = 11,
        DECEMBRE = 12
    }
    public class MoisManager
    {
        public static String getStringMois(Mois mois)
        {
            switch (mois)
            {
                case Mois.JANVIER:
                    return "janvier";
                case Mois.FEVRIER:
                    return "février";
                case Mois.MARS:
                    return "mars";
                case Mois.AVRIL:
                    return "avril";
                case Mois.MAI:
                    return "mai";
                case Mois.JUIN:
                    return "juin";
                case Mois.JUILLET:
                    return "juillet";
                case Mois.AOUT:
                    return "août";
                case Mois.SEPTEMBRE:
                    return "septembre";
                case Mois.OCTOBRE:
                    return "octobre";
                case Mois.NOVEMBRE:
                    return "novembre";
                case Mois.DECEMBRE:
                    return "décembre";
            }
            return "";
        }
    }
}
