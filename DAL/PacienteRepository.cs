using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace DAL
{
    public class PacienteRepository
    {
        private string ruta = @"Persona.txt";
        private List<Paciente> pacientes = new List<Paciente>();

        public void Guardar(Paciente paciente)
        {
            FileStream hilo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(hilo);
            escritor.Write(paciente.ToString());
            escritor.Close();
            hilo.Close();
        }
        public List<Paciente> leer()
        {
            string linea;
            pacientes.Clear();
            FileStream hilo = new FileStream(ruta,FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(hilo);
            while ((linea=lector.ReadLine())!=null)
            {
                pacientes.Add(Separador(linea));
            }
            lector.Close();
            hilo.Close();
            return pacientes;
        }
        public Paciente BuscarPaciente(string Identificacion)
        {
            pacientes.Clear();
            pacientes = leer();
            return pacientes.Where(p=>p.Identificacion==Identificacion).FirstOrDefault();
        }
        public void eliminar(string Identificacion)
        {
            pacientes.Clear();
            pacientes = leer();
            FileStream hilo = new FileStream(ruta,FileMode.Create);
            hilo.Close();
            foreach ( Paciente item in pacientes)
            {
                if ((item.Identificacion.Equals(Identificacion))!=false)Guardar(item);
            }

        }

        public int ContadorConFiltro(string texto)
        {
            pacientes.Clear();
            pacientes = leer();
            if (texto == "SUBSIDIADO")return pacientes.Count(p=>p.TipoAfiliacion == texto);
            else if (texto == "CONTRIBUTIVO") return pacientes.Count(p => p.TipoAfiliacion == texto);
            else return pacientes.Count();
        }
        public IList<Paciente> FiltroPaciente(string texto)
        {
            pacientes.Clear();
            pacientes = leer();
            if (texto == "SUBSIDIADO") return pacientes.Where(p=>p.TipoAfiliacion==texto).ToList();
            else if (texto == "CONTRIBUTIVO") return pacientes.Where(p => p.TipoAfiliacion == texto).ToList();
            return pacientes;
        }

        public Paciente Separador(string text)
        {
            Paciente paciente = new Paciente();
            string[] separado = text.Split(';');
            paciente.Nombre = separado[0];
            paciente.Apellido1 = separado[1];
            paciente.Apellido2 = separado[2];
            paciente.Identificacion = separado[3];
            paciente.TipoAfiliacion = separado[4];
            paciente.SalarioDevengado = double.Parse(separado[5]);

            return paciente;
        }

        


    }
}
