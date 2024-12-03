using eCommerce;

namespace Carrello_con_prodotti
{
    public partial class Form1 : Form
    {
        private Prodotto prodotto;
        private Carrello C;
        

        private int numeroSerialeIphone;

        public Form1()
        {
            InitializeComponent();
            C = new Carrello("00001");
            numeroSerialeIphone = 1;
            prodotto = new Prodotto("SIDEMAN", "Y2K ORBIT HOODIE", "000001", 35); // Inizializzazione di 'prodotto'
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seriale = numeroSerialeIphone.ToString("D5");
            var prodotto = new Prodotto("SIDEMAN", "Y2K ORBIT HOODIE", seriale, 35);
            C.aggiungiProdotto(prodotto);
            numeroSerialeIphone++;
            AggiornaInterfaccia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Carrello.SelectedItem != null)
            {
                Prodotto prodottoSelezionato = (Prodotto)Carrello.SelectedItem;
                C.rimuoviProdotto(prodottoSelezionato);
                AggiornaInterfaccia();
            }
        }

        private void AggiornaInterfaccia()
        {
            Carrello.DataSource = null;
            Carrello.DataSource = C.ProdottiCarrello;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C.svuotaCarrello();
            AggiornaInterfaccia();
        }
    }
}
