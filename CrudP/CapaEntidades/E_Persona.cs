using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Persona
    {
        private int _IdPersona;
        private string _NombrePersona;
        private string _ApellidosPersona;
        private DateTime _FechaNacimientoPersona;
        private string _TipoIdentificacionPersona;
        private int _NumeroIdentificacion;
        private int _EdadPersona;
        public int IdPersona
        {
            get
            {
                return _IdPersona;
            }

            set
            {
                _IdPersona = value;
            }
        }

        public string NombrePersona
        {
            get
            {
                return _NombrePersona;
            }

            set
            {
                _NombrePersona = value;
            }
        }

        public string ApellidosPersona
        {
            get
            {
                return _ApellidosPersona;
            }

            set
            {
                _ApellidosPersona = value;
            }
        }

        public DateTime FechaNacimientoPersona
        {
            get
            {
                return _FechaNacimientoPersona;
            }

            set
            {
                _FechaNacimientoPersona = value;
            }
        }

        public string TipoIdentificacionPersona
        {
            get
            {
                return _TipoIdentificacionPersona;
            }

            set
            {
                _TipoIdentificacionPersona = value;
            }
        }

        public int NumeroIdentificacion
        {
            get
            {
                return _NumeroIdentificacion;
            }

            set
            {
                _NumeroIdentificacion = value;
            }
        }

        public int EdadPersona
        {
            get
            {
                return _EdadPersona;
            }

            set
            {
                _EdadPersona = value;
            }
        }
    }
}
