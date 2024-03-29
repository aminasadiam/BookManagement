﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Author
    {
        public uint ID { get; set; }
        public string? FullName { get; set; }
        public string? Description { get; set; }


        #region Relations

        public List<Book>? Books { get; set; }

        #endregion
    }
}
