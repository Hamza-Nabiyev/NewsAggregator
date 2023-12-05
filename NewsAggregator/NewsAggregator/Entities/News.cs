using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsAggregator.Entities
{
    [Table("news")]
    public class News
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [ForeignKey(nameof(CategoryNews))]
        [Column("category_news")]
        public int CategoryNewsId { get; set; }
        public CategoryNews CategoryNews { get; set; }

        [ForeignKey(nameof(Source))]
        [Column("source")]
        public int SourceId { get; set; }
        public Source Source { get; set; }

        [Column("url")]
        public string Url { get; set; }

        [Column("date_of_publication")]
        public DateTime DateOfPublication{ get; set; }
    }
}
