using System;
using System.Windows;

namespace ToplamaUygulamasi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, RoutedEventArgs e)
        {
            islem();
        }

        public void islem()
        {
            try
            {
                int sayi1 = Convert.ToInt32(txtSayi1.Text);
                int sayi2 = Convert.ToInt32(txtSayi2.Text);
                int toplam = sayi1 + sayi2;
                txtSonuc.Text = toplam.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli sayılar giriniz.");
            }
        }
    }
}
