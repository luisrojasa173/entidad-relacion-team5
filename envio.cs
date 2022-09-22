using System;

namespace Pizzeria5.Ass.Dominio
{
    public class envio : Empleados
    {
        public string mediodePago {get; set;}
        public int DireccionFacturacion{get; set;}
        public int FechaEnvio{get; set;}
    }
}