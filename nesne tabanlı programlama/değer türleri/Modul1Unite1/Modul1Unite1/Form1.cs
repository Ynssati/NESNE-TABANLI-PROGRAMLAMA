using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GunlerEnumOrnek
{
    public partial class Form1 : Form
    {
        // Enum tanımı
        enum Gunler
        {
            Pazartesi,
            Sali,
            Carsamba,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
         
            Gunler[] gunDizisi = (Gunler[])Enum.GetValues(typeof(Gunler));

           
            foreach (Gunler gun in gunDizisi)
            {
                comboBox1.Items.Add(gun);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

