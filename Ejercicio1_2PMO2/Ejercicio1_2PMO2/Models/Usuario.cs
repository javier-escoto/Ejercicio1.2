using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicio1_2PMO2.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int id { set; get; }

        [MaxLength(100)]
        public String nombre { set; get; }

        [MaxLength(100)]
        public String apellidos { set; get; }

        public String edad { set; get; }

        public String correo { set; get; }
    }
}
