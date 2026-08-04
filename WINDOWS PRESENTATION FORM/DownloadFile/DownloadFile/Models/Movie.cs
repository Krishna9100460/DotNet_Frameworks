using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DownloadFile.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [Display(Name ="Release Date")]
        [DataType(DataType.Date)] 
        public DateTime? ReleaseDate { get; set;}
        public string? Gnere { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal price { get; set; }
    }
}
