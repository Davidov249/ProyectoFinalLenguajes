using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasTuring
{
    public class MultiplicacionUnaria
    {
        public List<String> Cinta = new List<string>();
        public string Estado = "q0";
        public int posCabezal = 3;
        public bool bandera = true;
        //Timer intervalo = new Timer(2000);
        public string resultado = "";
        public bool aceptar = false;
        public bool final = false;
        public int Num = 0;

        public void noAceptar()
        {
            aceptar = false;
            final = true;
        }

        public void Aceptar()
        {
            aceptar = true;
            final = true;
        }

        async Task Esperar()
        {
            await Task.Delay(2000);
        }

        public void resetear()
        {
            Cinta.Clear();
            Estado = "q0";
            posCabezal = 3;
            bandera = true;
            final = false;
            Num = 0;
        }

        public List<String> ArmarCinta(String cadena)
        {
            Cinta.Add("B");
            Cinta.Add("B");
            Cinta.Add("B");
            for (int i = 0; i < cadena.Length; i++)
            {
                Cinta.Add(cadena[i].ToString());
            }
            Cinta.Add("B");
            Cinta.Add("B");
            Cinta.Add("B");
            return Cinta;
        }

        public async void Ejecutar()
        {
            while (bandera)
            {
                await Esperar();
                if (posCabezal >= Cinta.Count() - 1)
                {
                    Cinta.Add("B");
                }
                switch (Estado)
                {
                    case "q0":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q1";
                                Cinta[posCabezal] = "X";
                                posCabezal++;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q1":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q1";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            case "*":
                                Estado = "q2";
                                Cinta[posCabezal] = "*";
                                posCabezal++;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q2":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q3";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            case "=":
                                Estado = "q11";
                                Cinta[posCabezal] = "=";
                                posCabezal--;
                                break;
                            case "Y":
                                Estado = "q2";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q3":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q3";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            case "=":
                                Estado = "q4";
                                Cinta[posCabezal] = "=";
                                posCabezal++;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q4":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q4";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            case "B":
                                Estado = "q5";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q5":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q5";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            case "*":
                                Estado = "q5";
                                Cinta[posCabezal] = "*";
                                posCabezal--;
                                break;
                            case "=":
                                Estado = "q5";
                                Cinta[posCabezal] = "=";
                                posCabezal--;
                                break;
                            case "X":
                                Estado = "q6";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            case "Y":
                                Estado = "q5";
                                Cinta[posCabezal] = "Y";
                                posCabezal--;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q6":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q7";
                                Cinta[posCabezal] = "X";
                                posCabezal++;
                                break;
                            case "*":
                                Estado = "q10";
                                Cinta[posCabezal] = "*";
                                posCabezal--;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q7":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q7";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            case "*":
                                Estado = "q7";
                                Cinta[posCabezal] = "*";
                                posCabezal++;
                                break;
                            case "=":
                                Estado = "q8";
                                Cinta[posCabezal] = "=";
                                posCabezal++;
                                break;
                            case "Y":
                                Estado = "q7";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q8":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q8";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            case "B":
                                Estado = "q5";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q9":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q9";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            case "*":
                                Estado = "q9";
                                Cinta[posCabezal] = "*";
                                posCabezal--;
                                break;
                            case "=":
                                Estado = "q9";
                                Cinta[posCabezal] = "=";
                                posCabezal--;
                                break;
                            case "X":
                                Estado = "q6";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q10":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q10";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            case "B":
                                Estado = "q0";
                                Cinta[posCabezal] = "B";
                                posCabezal++;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q11":
                        switch (Cinta[posCabezal])
                        {
                            case "*":
                                Estado = "q12";
                                Cinta[posCabezal] = "*";
                                posCabezal--;
                                break;
                            case "Y":
                                Estado = "q11";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q12":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q12";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            case "X":
                                Estado = "q12";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            case "B":
                                bandera = false;
                                Aceptar();
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        noAceptar();
                        bandera = false;
                        break;
                }
                Num++;
            } 
        }
    }
}
