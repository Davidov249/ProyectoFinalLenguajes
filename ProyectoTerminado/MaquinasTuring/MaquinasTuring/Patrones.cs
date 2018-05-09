using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasTuring
{
    public class Patrones
    {
        public List<String> Cinta = new List<string>();
        public string Estado = "q0";
        public int posCabezal = 3;
        public bool bandera = true;
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
                            case "a":
                                Estado = "q1";
                                Cinta[posCabezal] = "X";
                                posCabezal++;
                                break;
                            case "b":
                                Estado = "q2";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            case "c":
                                Estado = "q3";
                                Cinta[posCabezal] = "Z";
                                posCabezal++;
                                break;
                            case "X":
                                Estado = "q0";
                                Cinta[posCabezal] = "X";
                                posCabezal++;
                                break;
                            case "Y":
                                Estado = "q0";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            case "Z":
                                Estado = "q0";
                                Cinta[posCabezal] = "Z";
                                posCabezal++;
                                break;
                            case "B":
                                Estado = "q5";
                                Cinta[posCabezal] = "B";
                                posCabezal--;
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
                            case "a":
                                Estado = "q1";
                                Cinta[posCabezal] = "a";
                                posCabezal++;
                                break;
                            case "b":
                                Estado = "q1";
                                Cinta[posCabezal] = "b";
                                posCabezal++;
                                break;
                            case "c":
                                Estado = "q1";
                                Cinta[posCabezal] = "c";
                                posCabezal++;
                                break;
                            case "X":
                                Estado = "q1";
                                Cinta[posCabezal] = "X";
                                posCabezal++;
                                break;
                            case "Y":
                                Estado = "q1";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            case "Z":
                                Estado = "q1";
                                Cinta[posCabezal] = "Z";
                                posCabezal++;
                                break;
                            case "B":
                                Estado = "q4";
                                Cinta[posCabezal] = "X";
                                posCabezal--;
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
                            case "a":
                                Estado = "q2";
                                Cinta[posCabezal] = "a";
                                posCabezal++;
                                break;
                            case "b":
                                Estado = "q2";
                                Cinta[posCabezal] = "b";
                                posCabezal++;
                                break;
                            case "c":
                                Estado = "q2";
                                Cinta[posCabezal] = "c";
                                posCabezal++;
                                break;
                            case "X":
                                Estado = "q2";
                                Cinta[posCabezal] = "X";
                                posCabezal++;
                                break;
                            case "Y":
                                Estado = "q2";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            case "Z":
                                Estado = "q2";
                                Cinta[posCabezal] = "Z";
                                posCabezal++;
                                break;
                            case "B":
                                Estado = "q4";
                                Cinta[posCabezal] = "Y";
                                posCabezal--;
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
                            case "a":
                                Estado = "q3";
                                Cinta[posCabezal] = "a";
                                posCabezal++;
                                break;
                            case "b":
                                Estado = "q3";
                                Cinta[posCabezal] = "b";
                                posCabezal++;
                                break;
                            case "c":
                                Estado = "q3";
                                Cinta[posCabezal] = "c";
                                posCabezal++;
                                break;
                            case "X":
                                Estado = "q3";
                                Cinta[posCabezal] = "X";
                                posCabezal++;
                                break;
                            case "Y":
                                Estado = "q3";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            case "Z":
                                Estado = "q3";
                                Cinta[posCabezal] = "Z";
                                posCabezal++;
                                break;
                            case "B":
                                Estado = "q4";
                                Cinta[posCabezal] = "Z";
                                posCabezal--;
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
                            case "a":
                                Estado = "q4";
                                Cinta[posCabezal] = "a";
                                posCabezal--;
                                break;
                            case "b":
                                Estado = "q4";
                                Cinta[posCabezal] = "b";
                                posCabezal--;
                                break;
                            case "c":
                                Estado = "q4";
                                Cinta[posCabezal] = "c";
                                posCabezal--;
                                break;
                            case "X":
                                Estado = "q4";
                                Cinta[posCabezal] = "X";
                                posCabezal--;
                                break;
                            case "Y":
                                Estado = "q4";
                                Cinta[posCabezal] = "Y";
                                posCabezal--;
                                break;
                            case "Z":
                                Estado = "q4";
                                Cinta[posCabezal] = "Z";
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
                    case "q5":
                        switch (Cinta[posCabezal])
                        {
                            case "X":
                                Estado = "q5";
                                Cinta[posCabezal] = "a";
                                posCabezal--;
                                break;
                            case "Y":
                                Estado = "q5";
                                Cinta[posCabezal] = "b";
                                posCabezal--;
                                break;
                            case "Z":
                                Estado = "q5";
                                Cinta[posCabezal] = "c";
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
