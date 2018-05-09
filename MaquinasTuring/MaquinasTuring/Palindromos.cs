using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasTuring
{
    public class Palindromos
    {
        public List<String> Cinta = new List<string>();
        public string Estado = "q0";
        public int posCabezal = 3;
        public bool bandera = true;
        public string resultado = "";
        public bool aceptar = false;
        public bool final = false;
        //public int vel = 0;

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
                //for (int i = 0; i < 10000000; i++)
                //{

                //}
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
                                Estado = "q3";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            case "c":
                                Estado = "q5";
                                Cinta[posCabezal] = "Z";
                                posCabezal++;
                                break;
                            case "X":
                                Estado = "q8";
                                Cinta[posCabezal] = "X";
                                posCabezal++;
                                break;
                            case "Y":
                                Estado = "q8";
                                Cinta[posCabezal] = "Y";
                                posCabezal++;
                                break;
                            case "Z":
                                Estado = "q8";
                                Cinta[posCabezal] = "Z";
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
                                Estado = "q2";
                                Cinta[posCabezal] = "X";
                                posCabezal--;
                                break;
                            case "Y":
                                Estado = "q2";
                                Cinta[posCabezal] = "Y";
                                posCabezal--;
                                break;
                            case "Z":
                                Estado = "q2";
                                Cinta[posCabezal] = "Z";
                                posCabezal--;
                                break;
                            case "B":
                                Estado = "q2";
                                Cinta[posCabezal] = "B";
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
                                Estado = "q6";
                                Cinta[posCabezal] = "X";
                                posCabezal--;
                                break;
                            case "X":
                                Estado = "q8";
                                Cinta[posCabezal] = "X";
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
                                Estado = "q4";
                                Cinta[posCabezal] = "B";
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
                            case "b":
                                Estado = "q6";
                                Cinta[posCabezal] = "Y";
                                posCabezal--;
                                break;
                            case "Y":
                                Estado = "q8";
                                Cinta[posCabezal] = "Y";
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
                            case "a":
                                Estado = "q5";
                                Cinta[posCabezal] = "a";
                                posCabezal++;
                                break;
                            case "b":
                                Estado = "q5";
                                Cinta[posCabezal] = "b";
                                posCabezal++;
                                break;
                            case "c":
                                Estado = "q5";
                                Cinta[posCabezal] = "c";
                                posCabezal++;
                                break;
                            case "X":
                                Estado = "q7";
                                Cinta[posCabezal] = "X";
                                posCabezal--;
                                break;
                            case "Y":
                                Estado = "q7";
                                Cinta[posCabezal] = "Y";
                                posCabezal--;
                                break;
                            case "Z":
                                Estado = "q7";
                                Cinta[posCabezal] = "Z";
                                posCabezal--;
                                break;
                            case "B":
                                Estado = "q7";
                                Cinta[posCabezal] = "B";
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
                            case "c":
                                Estado = "q6";
                                Cinta[posCabezal] = "Z";
                                posCabezal--;
                                break;
                            case "Z":
                                Estado = "q8";
                                Cinta[posCabezal] = "Z";
                                posCabezal++;
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
                            case "a":
                                Estado = "q6";
                                Cinta[posCabezal] = "a";
                                posCabezal--;
                                break;
                            case "b":
                                Estado = "q6";
                                Cinta[posCabezal] = "b";
                                posCabezal--;
                                break;
                            case "c":
                                Estado = "q6";
                                Cinta[posCabezal] = "c";
                                posCabezal--;
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
                            default:
                                noAceptar();
                                bandera = false;
                                break;
                        }
                        break;
                    case "q8":
                        bandera = false;
                        Aceptar();
                        break;
                    default:
                        noAceptar();
                        bandera = false;
                        break;
                }
            }
        }


    }
}
