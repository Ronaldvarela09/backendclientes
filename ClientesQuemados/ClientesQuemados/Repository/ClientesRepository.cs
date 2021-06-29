#region Documentación

/************************************************************************************************************
 * Unidad        : ClientesRepository                                                                      
 * Descripcion   : Clase usada como repositorio de datos.
 ***********************************************************************************************************/
#endregion Documentación

using ClientesQuemados.Model;
using System;
using System.Collections.Generic;

namespace ClientesQuemados.Repository
{
    public class ClientesRepository
    {
        public static List<ClientesModel> listaClientes = new List<ClientesModel>()
        {
            new ClientesModel() { Identificacion = "11111111", Nombre = "Roberto" , Edad = 26, FechaNacimiento = new DateTime(1995, 5, 28)},
            new ClientesModel() { Identificacion = "22222222", Nombre = "Andrea" , Edad = 26, FechaNacimiento = new DateTime(1995, 5, 10)},
            new ClientesModel() { Identificacion = "33333333", Nombre = "Anderson" , Edad = 27, FechaNacimiento = new DateTime(1994, 2, 9)},
            new ClientesModel() { Identificacion = "44444444", Nombre = "Jeison" , Edad = 27, FechaNacimiento = new DateTime(1994, 5, 25)},
            new ClientesModel() { Identificacion = "55555555", Nombre = "Carlos" , Edad = 28, FechaNacimiento = new DateTime(1993, 3, 29)},
            new ClientesModel() { Identificacion = "66666666", Nombre = "Jaime" , Edad = 28, FechaNacimiento = new DateTime(1993, 4, 2)},
            new ClientesModel() { Identificacion = "77777777", Nombre = "Ana" , Edad = 29, FechaNacimiento = new DateTime(1992, 5, 8)},
            new ClientesModel() { Identificacion = "88888888", Nombre = "Alicia" , Edad = 29, FechaNacimiento = new DateTime(1992, 4, 12)},
            new ClientesModel() { Identificacion = "99999999", Nombre = "Ronald" , Edad = 30, FechaNacimiento = new DateTime(1991, 4, 15)},
            new ClientesModel() { Identificacion = "10000000", Nombre = "Zamara" , Edad = 30, FechaNacimiento = new DateTime(1991, 4, 20)},
        };

        public IEnumerable<ClientesModel> ObtenerClientes()
        {
            return listaClientes;
        }
    }
}
