using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApIAssesment_17.Model
{
   
        [Table("Movie")]
        public class Movie
        {
            [Key]
            public int Id { get; set; }
            public string Title { get; set; }
            public string Director { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string Genre { get; set; }
            public double Rating { get; set; }
        }
}
