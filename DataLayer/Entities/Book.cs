using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Book
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public uint AuthorId { get; set; }
        public DateTime ReleaseDate { get; set; }

        #region Relations

        [ForeignKey(nameof(AuthorId))]        
        
        public Author? Author { get; set; }

        #endregion
    }
}
