using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsPortal.Logic
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
    }
}
