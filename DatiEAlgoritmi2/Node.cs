using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatiEAlgoritmi2
{

    /*
     * Elenco Colegato Singolo (Single Linked List)
     * Struttura di archiviazione concatenata di una tabella lineare, che è collegata da un nodo.
     * Ogni nodo è costituito da dati e puntatore al nodo successivo
     */

    public class Node
    {
        public string data;
        public Node next;

        public Node(string data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
