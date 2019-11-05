using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsPortal.Logic
{
    /// <summary>
    /// Preces dati
    /// </summary>
    public class Ad : BaseData
    {
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Nosaukums
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Apraksts
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// URL uz bildi
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Kategorijas identifikators
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Atrašanās vieta
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Pievienošanas laiks
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// Tālrunis
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// E-pasts
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Virtuāla īpašība - Kategorijas dati
        /// </summary>
        [NotMapped]
        public Category Category { get; set; }
    }
}
