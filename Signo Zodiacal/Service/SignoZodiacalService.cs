using Signo_Zodiacal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class SignoZodiacalService
    {

        public void Consultar(SignosViewModel svm)
        {
            switch (svm.Mes)
            {
                case (int)Mes.Enero:
                    if (svm.Mes == 1 && svm.Dia < 20)
                    {
                        svm.Resultado = "Capricornio";
                    }
                    else
                    {
                        svm.Resultado = "Acuario";
                    }
                    break;

                case (int)Mes.Febrero:
                    if (svm.Mes == 2 && svm.Dia < 19)
                    {
                        svm.Resultado = "Capricornio";
                    }
                    else
                    {
                        svm.Resultado = "Piscis";
                    }
                    break;


                case (int)Mes.Marzo:
                    if (svm.Mes == 3 && svm.Dia < 21)
                    {
                        svm.Resultado = "Piscis";
                    }
                    else
                    {
                        svm.Resultado = "Capricornio";
                    }
                    break;


                case (int)Mes.Abril:
                    if (svm.Mes == 4 && svm.Dia < 21)
                    {
                        svm.Resultado = "Aries";
                    }
                    else
                    {
                        svm.Resultado = "Tauro";
                    }
                    break;


                case (int)Mes.Mayo:
                    if (svm.Mes == 5 && svm.Dia < 22)
                    {
                        svm.Resultado = "Tauro";
                    }
                    else
                    {
                        svm.Resultado = "Geminis";
                    }
                    break;


                case (int)Mes.Junio:
                    if (svm.Mes == 6 && svm.Dia < 22)
                    {
                        svm.Resultado = "Geminis";
                    }
                    else
                    {
                        svm.Resultado = "Cancer";
                    }
                    break;


                case (int)Mes.Julio:
                    if (svm.Mes == 7 && svm.Dia < 23)
                    {
                        svm.Resultado = "Cancer";
                    }
                    else
                    {
                        svm.Resultado = "Leo";
                    }
                    break;


                case (int)Mes.Agosto:
                    if (svm.Mes == 8 && svm.Dia < 24)
                    {
                        svm.Resultado = "Leo";
                    }
                    else
                    {
                        svm.Resultado = "Virgo";
                    }
                    break;

                case (int)Mes.Septiembre:
                    if (svm.Mes == 9 && svm.Dia < 24)
                    {
                        svm.Resultado = "Virgo";
                    }
                    else
                    {
                        svm.Resultado = "Libra";
                    }
                    break;



                case (int)Mes.Octubre:
                    if (svm.Mes == 10 && svm.Dia < 24)
                    {
                        svm.Resultado = "Libra";
                    }
                    else
                    {
                        svm.Resultado = "Escorpio";
                    }
                    break;


                case (int)Mes.Noviembre:
                    if (svm.Mes == 11 && svm.Dia < 23)
                    {
                        svm.Resultado = "Escorpio";
                    }
                    else
                    {
                        svm.Resultado = "Sagitario";
                    }
                    break;


                case (int)Mes.Diciembre:
                    if (svm.Mes == 12 && svm.Dia < 22)
                    {
                        svm.Resultado = "Sagitario";
                    }
                    else
                    {
                        svm.Resultado = "Capricornio";
                    }
                    break;

            }
        }




    }
}

