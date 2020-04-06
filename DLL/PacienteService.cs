using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class PacienteService
    {
		PacienteRepository PacienteRe = new PacienteRepository(); 
			
        public string Guardar(Paciente paciente)
        {
			try
			{
				PacienteRe.Guardar(paciente);
				return "Se guardo correctamente";
			}
			catch (Exception e)
			{

				return $"Error: {e}";
			}
        }
		public bool existe(string Identificacion)
		{
			try
			{
				if (PacienteRe.BuscarPaciente(Identificacion) != null) return true;
				else return false;
			}
			catch (Exception e)
			{

				return false;
			}
			
		}
		public string Eliminar(string Identificiacion)
		{
			try
			{
				if (existe(Identificiacion))
				{
					PacienteRe.eliminar(Identificiacion);
					return "La informacion del paciente se elimino con exito";
				}
				else return "El paciente no existe en el registro"; 
			}
			catch (Exception e)
			{

				return $"Error:{e} ";
			}
			
		}
		



    }
}
