using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    /// <summary>
    /// Kategorijas dati
    /// </summary>
    public class Category : BaseData
    {

        /// <summary>
        /// Nosaukums
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Virskategorijas identifikators.
        /// Ja nav definēts - pamatkategorija.
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Virtuāla kolona - preču skaits
        /// </summary>
        [NotMapped]
        public int ItemCount { get; set; }
    }
}
