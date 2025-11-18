using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace CStanzaFattoDaMe
{
    public partial class Form1 : Form
    {
        private CStanza _stanzainiziale;
        private string nomeGestoreEvento = "Mario Rossi";

        public Form1()
        {
            InitializeComponent();
            _stanzainiziale = new CStanza();
            _stanzainiziale.StanzaPiena += CStanza_StanzaPiena;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CStanza_StanzaPiena(object? sender, StanzaEventArgs e)
        {
            MESSAGGI.Items.Add($"Troppe persone nella stanza: {e.NumeroPersoneStanza}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MESSAGGI.Items.Add($"Evento creato da {nomeGestoreEvento}");
            MESSAGGI.Items.Add("Creazione evento....");
            int Numeropersone = int.Parse(textBox1.Text);
            _stanzainiziale.Stanza(Numeropersone, nomeGestoreEvento);
            if (int.Parse(textBox1.Text) >= 100)
            {
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Green;
                MESSAGGI.Items.Add("Stanza non piena!");
            }
        }

        private void MESSAGGI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}