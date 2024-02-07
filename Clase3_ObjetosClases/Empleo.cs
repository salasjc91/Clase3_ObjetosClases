using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_ObjetosClases
{
     class Empleo
    {
        public string Empresa { get; set; }// propiedades
        public string DescripcionPuesto { get; set; }
        public double Salario { get; set; }
        public string Horario { get; set; }

        int IDEmpleo; //atributo privado


        //Constructores
        public Empleo()//dar valor a las propiedades 
        {
            IDEmpleo = 0;
            Empresa = "";
            DescripcionPuesto = "";
            Horario = "";
            Salario = 0;
        }

        public Empleo (int id, string empresa)
        {
            IDEmpleo = id;
            Empresa = empresa;
            DescripcionPuesto = "";
            Horario = "";
            Salario = 0;
        }



        //Metodos
        public void Postular(string persona)
        {
            Console.WriteLine($"Hola {persona}, tu entrevista para {DescripcionPuesto} es el jueves.");
        }
    }
}
