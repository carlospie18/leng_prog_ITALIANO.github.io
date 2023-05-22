using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Listas
    {
        public List<string> BanValores = new List<string>();
        public Dictionary<int, string> Msj = new Dictionary<int, string>();
        public List<string> VariablesName = new List<string>();

        public Listas()
        {
            //Lista con caracteres no aceptados en un nombre de variable
            this.BanValores.Add("!");
            this.BanValores.Add("@");
            this.BanValores.Add("#");
            this.BanValores.Add("$");
            this.BanValores.Add("%");
            this.BanValores.Add("^");
            this.BanValores.Add("&");
            this.BanValores.Add("*");
            this.BanValores.Add("(");
            this.BanValores.Add(")");
            this.BanValores.Add("-");
            this.BanValores.Add("_");
            this.BanValores.Add("=");
            this.BanValores.Add("+");
            this.BanValores.Add("[");
            this.BanValores.Add("{");
            this.BanValores.Add("}");
            this.BanValores.Add(";");
            this.BanValores.Add(":");
            this.BanValores.Add(";");
            this.BanValores.Add("'");
            this.BanValores.Add(",");
            this.BanValores.Add("<");
            this.BanValores.Add(">");
            this.BanValores.Add(",");
            this.BanValores.Add(".");
            this.BanValores.Add("?");
            this.BanValores.Add("/");
            this.BanValores.Add("|");
            this.BanValores.Add("~");
            this.BanValores.Add("`");
            this.BanValores.Add(" ");
            this.BanValores.Add("0");
            this.BanValores.Add("1");
            this.BanValores.Add("2");
            this.BanValores.Add("3");
            this.BanValores.Add("4");
            this.BanValores.Add("5");
            this.BanValores.Add("6");
            this.BanValores.Add("7");
            this.BanValores.Add("8");
            this.BanValores.Add("9");
            this.BanValores.Add("catena");
            this.BanValores.Add("totale");
            this.BanValores.Add("galleggiante");
            this.BanValores.Add("booleana");
            this.BanValores.Add("se");
            this.BanValores.Add("altra");
            this.BanValores.Add("per");
            this.BanValores.Add("mentre");
            this.BanValores.Add("stampa");

            //Diccionario para añadir todos los mensajes 
            this.Msj.Add(0, "Errore, impossibile convertire un valore booleano in un numero intero");//no se puede convertir un booleano en un entero
            this.Msj.Add(1, "Errore, impossibile convertire una stringa in un numero intero");//no se puede convertir una cadena en un entero
            this.Msj.Add(2, "Errore, alla variabile deve essere assegnato un valore");//Asignar un valor
            this.Msj.Add(3, "Errore, nome variabile vuoto");// Nombre de variable invalido
            this.Msj.Add(4, "Errore, variabile non definita");// Tipo Variable no definida 
            this.Msj.Add(5, "Errore, Un totale non può memorizzare una catena");// int no puede convertir en String 
            this.Msj.Add(6, "Errore, carattere non valido per assegnare un valore");// Caracter no valido (todo lo diferente a =)
            this.Msj.Add(7, "Debug terminato");//Depuracion terminada

            //Lista para añadir todos las varialbes en Italiano
            this.VariablesName.Add("catena");
            this.VariablesName.Add("totale");
            this.VariablesName.Add("galleggiante");
            this.VariablesName.Add("booleana");
            this.VariablesName.Add("se");
            this.VariablesName.Add("altra");
            this.VariablesName.Add("per");
            this.VariablesName.Add("mentre");
            this.VariablesName.Add("stampa");//Imprimir
            
        }
    }
}
