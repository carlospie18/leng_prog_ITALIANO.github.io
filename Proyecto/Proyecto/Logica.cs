using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Logica
    {
        List<Variable> variables = new List<Variable>();
        public string CrearCadenas(string Codigos)
        {
            string[] Cadenas = Codigos.Split(";"+"\n");
            
            return SepararCadenas(Cadenas);
            
        }

        public string SepararCadenas(string[] Cadenas)
        {
            List<string> AllResults = new List<string>();
            Validacion validar = new Validacion();
            string[] Codigo; 

            foreach (string a in Cadenas)
            {    
                Codigo = a.Split(" ");
                if(a != "")
                {
                    AllResults.Add(validar.TipoVariable(Codigo));
                }
            }

            return Imprimir(AllResults);
        }

        public void GuardarVarible(string Nombre, string Valor)
        {
            
            variables.Add(new Variable(Nombre, Valor));

        }

        public string Imprimir(List<string> Resultados)
        {
            string CadenaR = "";

            foreach (string a in Resultados)
            {
                CadenaR += a+"\n";
            }
            return CadenaR;
        }

        public string PrintAnalisis(string [] Valores)
        {
            string Imprimir = "";
            for (int i = 1; i < Valores.Length; i++)
            {
                if (Valores[i] == "[")
                {
                    i++;
                    Imprimir += BusquedaVariables(Valores, i) +" ";
                    i = SumarPos(Valores, i);
                }
                else
                {
                    Imprimir += Valores[i]+ " ";
                }
            }
            return Imprimir;
        }

        public int SumarPos(string[] Valores, int pos)
        {
            if (Valores[pos] == "]")
            {
                return pos++;
            }
            else
            {
                pos = pos + 1;
                return SumarPos(Valores, pos);
            }
            
        }

        public string BusquedaVariables(string[] Valores, int Pos)
        {
            List<string> GVariables = new List<string>();
            
            int i = Pos;
            while (Valores[i] != "]")
            {
                GVariables.Add(Valores[i]);
                i++;
            }

            return ExtraerValores(GVariables);
        }

        public string ExtraerValores(List<string> GVariables)
        {
            string Valores = "";
            foreach (Variable a in variables)
            {
                if (GVariables.Contains(a.nombre))
                {
                    Valores += a.valor;
                }
            }
            return Valores;
        }
    }
}
