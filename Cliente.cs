using System;

namespace Pizzeria5.Ass.Dominio
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Username{get; set;}
        public int  password{get; set;}
        public String Nombre{get; set;}
        public String Apellido{get;set;}
        public String NumeroTelefono{get;set;}
        public int DocumentoIdentidad{get;set;}
        public string Ciudad{get;set;}
        public string Departamento{get;set;}
        public string Pais{get;set;}
        public int Telefono{get;set;}
        public string Imeil{get;set;}
        public Genero Genero {get; set;}
    }
}

