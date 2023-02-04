using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ExercicioApi.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Synopsis { get; set; }

        [Required]
        public string? Rating { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
