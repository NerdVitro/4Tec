using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _4Tec.Classes
{
    static public class Constantes
    {
        readonly static private string _ConnectionString = @"Data Source=DESKTOP-8C0QSSV\SQLEXPRESS;Initial Catalog=BD_Choco;Integrated Security=True";
        readonly static private string _CULTUREINFO = "pt-BR";
        readonly static private Color _ColorForm = Color.White;
        readonly static private Color _ColorButonSelect = Color.FromArgb(252, 225, 190);
        readonly static private Color _ColorPanel = Color.FromArgb(250, 204, 141);
        readonly static private Color _ColorLogo = Color.FromArgb(255, 159, 0);

        static public string ConnectionString { get => _ConnectionString; }
        public static string Cultureinfo { get => _CULTUREINFO; }
        public static Color ColorForm { get => _ColorForm; }
        public static Color ColorButonSelect { get => _ColorButonSelect; }
        public static Color ColorPanel {  get => _ColorPanel; }
        public static Color ColorLogo {  get => _ColorLogo; }
    }
}
