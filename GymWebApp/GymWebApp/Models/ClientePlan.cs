using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebApp.Models
{
    public class ClientePlan
    {
        [Key, Column(Order = 1), ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [Key, Column(Order = 2), ForeignKey("Plan")]
        public int IdPlan { get; set; }
        

        public virtual Cliente Cliente { get; set; }
        public virtual Plan Plan { get; set; }
    }
}