using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace TCC.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        [AllowNull]
        public int Andaimes_10 { get; set; }
        [AllowNull]
        public int Andaimes_13 { get; set; }
        [AllowNull]
        public int Andaimes_15 { get; set; }
        [AllowNull]
        public int Andaimes_20 { get; set; }
        [AllowNull]
        public int Bitoneira { get; set; }
        [AllowNull]
        public int Escora_35 { get; set; }
        [AllowNull]
        public int Escora_50 { get; set; }
        [AllowNull]
        public int Pe_Regulador { get; set; }
        [AllowNull]
        public int Lastro_10 { get; set; }
        [AllowNull]
        public int Lastro_15 { get; set; }
        [AllowNull]
        public int Lastro_20 { get; set; }
        [AllowNull]
        public int Pranchao { get; set; }
        [AllowNull]
        public int Rodanas { get; set; }
        [AllowNull]
        public int Travas { get; set; }
    }
}