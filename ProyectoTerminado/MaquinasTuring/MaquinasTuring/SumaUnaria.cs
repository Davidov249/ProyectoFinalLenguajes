using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasTuring
{
    public class SumaUnaria
    {
        public List<String> Cinta = new List<string>();
        public string Estado = "q0";
        public int posCabezal = 3;
        public bool bandera = true;
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
                            case "+":
                                Estado = "q0";
                                Cinta[posCabezal] = "+";
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
                    case "q1":
                        switch (Cinta[posCabezal])
                        {
                            case "u":
                                Estado = "q1";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            case "+":
                                Estado = "q1";
                                Cinta[posCabezal] = "+";
                                posCabezal++;
                                break;
                            case "=":
                                Estado = "q2";
                                Cinta[posCabezal] = "=";
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
                                Estado = "q2";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            case "B":
                                Estado = "q3";
                                Cinta[posCabezal] = "u";
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
                            case "u":
                                Estado = "q3";
                                Cinta[posCabezal] = "u";
                                posCabezal--;
                                break;
                            case "+":
                                Estado = "q3";
                                Cinta[posCabezal] = "+";
                                posCabezal--;
                                break;
                            case "=":
                                Estado = "q3";
                                Cinta[posCabezal] = "=";
                                posCabezal--;
                                break;
                            case "X":
                                Estado = "q0";
                                Cinta[posCabezal] = "u";
                                posCabezal++;
                                break;
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q4":
                        bandera = false;
                        Aceptar();
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
