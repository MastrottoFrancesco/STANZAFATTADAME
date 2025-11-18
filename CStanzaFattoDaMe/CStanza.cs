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

        public string NomeControllore { get; }
        public StanzaEventArgs(int _persone, string nomeControllore)
        {
            NumeroPersoneStanza = _persone;
            NomeControllore = nomeControllore;

        }
    }
    public class CStanza
    {
        public event EventHandler<StanzaEventArgs> StanzaPiena;
        
        public void Stanza(int _persone,string nomeControllore)
        {
            if(_persone > 100)
            {
                OnStanzaPiena(new StanzaEventArgs(_persone,nomeControllore));
            }
        }

        protected virtual void OnStanzaPiena(StanzaEventArgs e)
        {
            StanzaPiena?.Invoke(this, e);
        } 
    }
   
}
