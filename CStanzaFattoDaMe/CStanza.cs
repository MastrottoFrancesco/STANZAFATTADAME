using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStanzaFattoDaMe
{
    public class StanzaEventArgs : EventArgs
    {
        public int NumeroPersoneStanza { get; }
        public StanzaEventArgs(int _persone)
        {
            NumeroPersoneStanza = _persone;
        }
    }
    public class CStanza
    {
        public event EventHandler<StanzaEventArgs> StanzaPiena;
        
        public void Stanza(int _persone)
        {
            Console.WriteLine("Controllo Stanza partito....");
            if(_persone > 100)
            {
                OnStanzaPiena(new StanzaEventArgs(_persone));
            }
            else
            {
                Console.WriteLine("Stanza non piena!");
            }
        }

        protected virtual void OnStanzaPiena(StanzaEventArgs e)
        {
            StanzaPiena?.Invoke(this, e);
        } 
    }

    public class Program
    {
        static void Main()
        {
            CStanza stanzaprova = new CStanza();
            stanzaprova.StanzaPiena += Stanzaprova_StanzaPiena;
            stanzaprova.Stanza(123);
        }
        static void Stanzaprova_StanzaPiena(object sender,StanzaEventArgs e)
        {
            Console.WriteLine("Evento creato: Troppe persone presenti nella stanza!");
        }
    }
}
