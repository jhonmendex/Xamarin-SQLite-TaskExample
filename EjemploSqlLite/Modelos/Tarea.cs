using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSqlLite.Modelos
{
    class Tarea
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(150)]
        public String Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public bool Completada { get; set; }

        public override string ToString()
        {
            return string.Format("Nombre : {0}, Fecha : {1}, Hora : {2},  Completada : {3}", Nombre, Fecha,Hora, Completada);
        }
    }
}
