namespace Esercitazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float prezzo;

        //aggiunge un prodotto al carrello
        private void addproduct_Click(object sender, EventArgs e)
        {
            string name = lista.SelectedItems[0].Text; //salva il nome del piatto cliccato, riciclato dal crud del ristorante
            carrello.Items.Add(name);

            name = name.Split('$')[0];
            prezzo = prezzo + float.Parse(name);
            pricelabel.Text = "TOT: " + prezzo;
        }

        //rimuove un prodotto dal carrello
        private void remove_Click(object sender, EventArgs e)
        {
            string name = lista.SelectedItems[0].Text;
            name = name.Split('$')[0];
            prezzo = prezzo - float.Parse(name);
            pricelabel.Text = "TOT: " + prezzo;

            carrello.Items.RemoveAt(carrello.SelectedIndex);
        }

        //svuota interamente il carrello
        private void empty_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void carrello_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}