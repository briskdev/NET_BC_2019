using AdsPortal.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdsPortal.Models
{
    public class AdModel
    {
        /// <summary>
        /// Identifikators
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        [Required]
        public decimal Price { get; set; }
        /// <summary>
        /// Nosaukums
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// Apraksts
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// URL uz bildi
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Kategorijas identifikators
        /// </summary>
        [Required]
        public int CategoryId { get; set; }
        /// <summary>
        /// Atrašanās vieta
        /// </summary>
        [Required]
        public string Location { get; set; }
        /// <summary>
        /// Pievienošanas laiks
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// Tālrunis
        /// </summary>
        [Required]
        public string Telephone { get; set; }
        /// <summary>
        /// E-pasts
        /// </summary>
        [Required]
        public string Email { get; set; }

        public List<Category> Categories { get; set; }
    }
}
