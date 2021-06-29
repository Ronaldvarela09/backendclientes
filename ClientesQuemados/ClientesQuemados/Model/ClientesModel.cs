#region Documentación
/************************************************************************************************************
 * Unidad        : ClientesModel                                                                      
 * Descripcion   : Clase usada como modelo para clientes
 ***********************************************************************************************************/
#endregion Documentación

using System;

namespace ClientesQuemados.Model
{
    public class ClientesModel
    {
        /// <summary>
        /// Propiedad  indentificación del cliente 
        /// </summary>
        public string Identificacion { get; set; }

        /// <summary>
        /// Propiedad Nombre del cliente 
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Propiedad Edad del cliente 
        /// </summary>
        public int Edad { get; set; }

        /// <summary>
        /// Propiedad fecha de nacimiento del cliente 
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
    }
}
