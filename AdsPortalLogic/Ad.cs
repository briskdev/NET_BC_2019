﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsPortal.Logic
{
    /// <summary>
    /// Preces dati
    /// </summary>
    public class Ad
    {
        /// <summary>
        /// Identifikators
        /// </summary>
        public int Id { get; set; }
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
    }
}
