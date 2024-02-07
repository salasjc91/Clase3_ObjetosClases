namespace Clase3_ObjetosClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crea instancia
            //manera 1:
            Empleo e1 = new Empleo();
            e1.DescripcionPuesto = "Administrador de tienda";
            e1.Salario = 9000;
            e1.Postular("Cesar");
            //manera 2:
            Empleo e2;                     
            e2 = new Empleo()
            {
                Empresa="BSCI",DescripcionPuesto="Auxiliar de bodega", Salario = 450000
            };
            e2.Postular("Cesar");

            

             

        }
    }
}
