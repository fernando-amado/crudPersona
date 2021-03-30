using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio

{

   public class N_Persona
    {
        D_Persona objData = new D_Persona();
        public List<E_Persona> ListandoPersona(string buscar)
        {
            return objData.ListarPersonas(buscar);
        }
        public List<E_Persona> ConsultandoPersona(E_Persona persona)
        {
            return objData.ConsultarPersonas(persona);
        }
        public void InsertandoPersona(E_Persona persona)
        {
            objData.InsertarPersona(persona);
        }
        public void EditandoPersona(E_Persona persona)
        {
            objData.EditarPersona(persona);
        }
        public void EliminandoPersona(E_Persona persona)
        {
            objData.EliminarPersona(persona);
        }
    }
}
