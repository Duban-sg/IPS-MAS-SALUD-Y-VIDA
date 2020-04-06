using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace IPS_MAS_SALUD_Y_VIDA
{
    class Program
    {
        static LiquidacionCuotaModeradoraService LCMS = new LiquidacionCuotaModeradoraService();
        static PacienteService PS = new PacienteService();

        static void Main(string[] args)
        {
            int salir = 0;
            int respuesta = 0;
            while (salir==0)
            {
                Console.WriteLine("\n\nMenu Ips\n\n");
                Console.WriteLine("1)Registar paciente\n");
                Console.WriteLine("2)Registrar Liquidacion\n");
                Console.WriteLine("3)Mostrar lista de liquidaciones\n");
                Console.WriteLine("4)Eliminar Registro de liquidacion\n");
                Console.WriteLine("5)Modificar Valor de servicion de liquidacion\n");
                Console.WriteLine("6)salir\n\n");
                Console.WriteLine("=");
                respuesta= int.Parse(Console.ReadLine());

                switch (respuesta)
                {
                    case 1:
                        CrearPaciente();
                        break;
                    case 2:
                        CrearLiquidacion();
                        break;
                    case 3:
                        VerLista();
                        break;
                    case 4:
                        EliminarLiquidacion();
                        break;
                    case 5:
                        ModificarLiquidacion();
                        break;
                    case 6:
                        salir = 1;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            }




            
        }

        public static void CrearPaciente()
        {
            int salir= 0;
            int afiliacion;
            Paciente paciente = new Paciente();
            Console.Write("Nombre del paciente: ");
            paciente.Nombre = Console.ReadLine();
            Console.Write("Primer apellido del paciente: ");
            paciente.Apellido1 = Console.ReadLine();
            Console.Write("Segundo apellido del paciente: ");
            paciente.Apellido2 = Console.ReadLine();
            Console.Write("Identificaion del paciente: ");
            paciente.Identificacion = Console.ReadLine();
            while (salir==0)
            {

                Console.Write("Tipo de afiliacion del paciente\n");
                Console.Write("1)Subcidiado\n");
                Console.Write("2)Contributivo\n");
                Console.Write("=");
                afiliacion = int.Parse(Console.ReadLine());
                switch (afiliacion)
                {
                    case 1:
                        paciente.TipoAfiliacion = true;
                        salir = 1;
                        break;
                    case 2:
                        paciente.TipoAfiliacion = false;
                        salir = 1;
                        break;
                    default:
                        Console.WriteLine("respuesta Incorrecta");
                        break;

                }

            }
            Console.Write("Salario Devengado: ");
            paciente.SalarioDevengado = Double.Parse(Console.ReadLine());
            PS.Guardar(paciente);
        }
        public static void CrearLiquidacion()
        {
            LiquidacionCuotaModeradora liquidacion = new LiquidacionCuotaModeradora();
            string Ipaciente;
            Console.Write("Identificaion del paciente: ");
            Ipaciente = Console.ReadLine();
            if (PS.existe(Ipaciente))
            {
                Paciente paciente = PS.Buscar(Ipaciente);
                Console.Write("Numero de Liquidacion: ");
                liquidacion.NDeliquidacion =double.Parse(Console.ReadLine());
                Console.Write("Valor del servicio: ");
                liquidacion.ValorServicio = double.Parse(Console.ReadLine());
                liquidacion.NombrePaciente = $"{ paciente.Nombre} {paciente.Apellido1} {paciente.Apellido2}";
                liquidacion.IdentificacionPaciente = paciente.Identificacion;
                if (paciente.TipoAfiliacion) liquidacion.TipoAfiliacion = "SUBSIDIADO";
                else liquidacion.TipoAfiliacion = "CONTRIBUTIVO";
                liquidacion.CalcularCuota();
                LCMS.GuardarLiquidacion(liquidacion);
            }
            else Console.WriteLine( "El paciente no se encuentra registrado");




        }
        public static void VerLista()
        {
            List<LiquidacionCuotaModeradora> lCM = LCMS.BuscarLiquidaciones();
            if (lCM != null)
            {
                foreach (LiquidacionCuotaModeradora item in lCM)
                {
                    Console.WriteLine(item.Imprimir());
                    Console.WriteLine("\n\n\n Precione cualquier tecla");
                    Console.ReadKey();
                }
            }
            else Console.WriteLine("No hay registro de liquidaciones");
            
        }
        public static void EliminarLiquidacion()
        {
            string identificaion;
            Console.WriteLine("Ingrese el numero de liquidacion");
            identificaion = Console.ReadLine();
            Console.WriteLine(LCMS.eliminar(identificaion));
            
        }
        public static void ModificarLiquidacion()
        {
            string identificaion;
            double valorServisio;
            Console.WriteLine("Ingrese el numero de Liquidacion:");
            identificaion = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo valor del servicio:");
            valorServisio = double.Parse(Console.ReadLine());
            Console.WriteLine(LCMS.modificar(identificaion, valorServisio));
        }


    }
}
