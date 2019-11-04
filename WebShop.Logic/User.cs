﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    /// <summary>
    /// Lietotāja dati
    /// </summary>
    public class User : BaseData
    {
        /// <summary>
        /// E-pasts
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Parole
        /// </summary>
        public string Password { get; set; }
    }
}
