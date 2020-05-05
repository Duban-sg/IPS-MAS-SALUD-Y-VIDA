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
				
				
				if (existe(paciente.Identificacion) == false)
				{
					PacienteRe.Guardar(paciente);
					return "Se guardo correctamente";
				}
				else
				{
					return "El paciente ya existe";
				}
				
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
			catch (Exception)
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
		public Paciente Buscar(string Identificiacion)
		{
			try
			{
				return PacienteRe.BuscarPaciente(Identificiacion);

			}
			catch (Exception)
			{

				return null;
			}
		}
		
		public RespuestaValides ValidarCedula(string numero)
		{
			RespuestaValides respuesta = new RespuestaValides();
			try
			{
				long auxiliar = long.Parse(numero);
				if (numero.Length>12)
				{
					respuesta.valides = false;
					respuesta.error = "La cedula solo puede contener 12 caracteres como maimo";
					return respuesta;
				}
				respuesta.valides = true;
				return respuesta;
				
			}
			catch (Exception)
			{
				respuesta.valides = false;
				respuesta.error = "La identificacion solo puede contener caracteres numericos";
				return respuesta;
			}
		}

		public bool EsNumero(string texto)
		{
			try
			{
				double numero = double.Parse(texto);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public int CantidadConFiltro(string texto)
		{
			try
			{
				return PacienteRe.ContadorConFiltro(texto);
			}
			catch (Exception)
			{

				throw;
			}
		}
		public IList<Paciente> FiltroPacientes(string texto)
		{
			try
			{
				return PacienteRe.FiltroPaciente(texto);
			}
			catch (Exception)
			{

				throw;
			}
		}
    }

	public class RespuestaValides
	{
		public bool valides { get; set; }
		public string error { get; set; }
	}
}
