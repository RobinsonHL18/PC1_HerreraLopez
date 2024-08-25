using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC1_HerreraLopez.Models
{
    public class Operaciones
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaOperacion { get; set; }
        public List<string>? Instrumentos { get; set; }
        public decimal MontoAbonar { get; set; }
        public decimal IGV;
        public decimal Comision { get; set; }
        public decimal Total { get; set; }

        public void CalcularOperacion()
        {
            IGV = 0M;
            foreach (var instrumento in Instrumentos)
            {
                decimal montoInstrumento = instrumento switch
                {
                    "SP500" => 500M,
                    "DowJones" => 300M,
                    "BonosUS" => 120M,
                    _ => 0M
                };
                IGV += montoInstrumento * 0.18M;
            }

            Comision = MontoAbonar > 300 ? 3M : 1M;
            Total = MontoAbonar + IGV + Comision;
        }
    }
}