using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Validacion : Listas
    {
        private Logica logica = new Logica();

        public string TipoVariable(string[] Codigo)
        {
            if (VariablesName.Contains(Codigo[0]))
            {
                if (Codigo[0] == VariablesName[0])
                {
                    return VlidarString(Codigo);
                }
                else if (Codigo[0] == VariablesName[1])
                {
                    return VlidarEntero(Codigo);
                }
                else if (Codigo[0] == VariablesName[2])
                {
                    return VlidarFlotante(Codigo);
                }
                else if (Codigo[0] == VariablesName[3])
                {
                    return VlidarBoolean(Codigo); 
                }
                else if (Codigo[0] == VariablesName[4])
                {
                    return "Llamar metodo de validacion de if/se y verificar si tiene else/antra";
                }
                else if (Codigo[0] == VariablesName[6])
                {
                    return "Llamar metodo de validacion de for/per /////verificar que haya otro for/while";
                }
                else if (Codigo[0] == VariablesName[7])
                {
                    return "Llamar metodo de validacion de while/mentre /////verificar que haya otro for/while";
                }
                else if (Codigo[0] == VariablesName[8])
                {
                    return logica.PrintAnalisis(Codigo); ;
                }
                else
                {
                    return Msj[4];
                }
            }
            else
            {
                return Msj[4];  
            }
        }

        public string VlidarEntero(String[] Codigo)
        {
            if (!BanValores.Contains(Codigo[1]))
            {
                if (Codigo[2] == "=")
                {
                    if (Codigo[3] != "")
                    {
                        int a = 0;
                        if (int.TryParse(Codigo[3], out a))
                        {
                            logica.GuardarVarible(Codigo[1], Codigo[3]);
                            return "\n";
                        }
                        else
                        {
                            return Msj[5];// int no puede convertir en String 
                        }
                    }
                    else
                    {
                        return Msj[2];//Asignar un valor
                    }
                }
                else
                {
                    return Msj[6];// Caracter no valido (todo lo diferente a =)
                }
            }
            else
            {
                return Msj[3];//Nombre de variable inválido
            }
        }

        public string VlidarBoolean(String[] Codigo)
        {
            if (!BanValores.Contains(Codigo[1]))
            {
                if (Codigo[2] == "=")
                {
                    if (Codigo[3] != "")
                    {
                        
                        if (Codigo[3] == "vero" || Codigo[3] == "falso")
                        
                        {
                            logica.GuardarVarible(Codigo[1], Codigo[3]);
                            return "\n";
                        }
                        else
                        {
                            return Msj[5];// boolean no puede convertir en String 
                        }
                    }
                    else
                    {
                        return Msj[2];//Asignar un valor
                    }
                }
                else
                {
                    return Msj[6];// Caracter no valido (todo lo diferente a =)
                }
            }
            else
            {
                return Msj[3];//Nombre de variable inválido
            }

        }

        public string VlidarString(String[] Codigo)
        {
            if (!BanValores.Contains(Codigo[1]))
            {
                if (Codigo[2] == "=")
                {
                    if (Codigo[3] != "")
                    {

                        if (Codigo[3] == "catena" )

                        {
                            logica.GuardarVarible(Codigo[1], Codigo[3]);
                            return "\n";
                        }
                        else
                        {
                            return Msj[5];// el string no puede convertir en String 
                        }
                    }
                    else
                    {
                        return Msj[2];//Asignar un valor
                    }
                }
                else
                {
                    return Msj[6];// Caracter no valido (todo lo diferente a =)
                }
            }
            else
            {
                return Msj[3];//Nombre de variable inválido
            }
        }

        public string VlidarFlotante(String[] Codigo)
        {
            if (!BanValores.Contains(Codigo[1]))
            {
                if (Codigo[2] == "=")
                {
                    if (Codigo[3] != "")
                    {

                        if (Codigo[3] == "galleggiante")

                        {
                            logica.GuardarVarible(Codigo[1], Codigo[3]);
                            return "\n";
                        }
                        else
                        {
                            return Msj[5];// el flotante no se puede convertir en String 
                        }
                    }
                    else
                    {
                        return Msj[2];//Asignar un valor
                    }
                }
                else
                {
                    return Msj[6];// Caracter no valido (todo lo diferente a =)
                }
            }
            else
            {
                return Msj[3];//Nombre de variable inválido
            }
            //Seguir 



        }
    }
}
