using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestwindSystem.Entity
{
    [Table(name:"Categories")]
    public class Category
    {
        [Key]
        [Column(name:"CategoryID")]
        public int Id { get; set; }
        [Required(ErrorMessage ="CatergoryName is required")]
        [MaxLength(15, ErrorMessage ="CategoryName max length is 15")]
        public string CategoryName { get; set; } = String.Empty;
        [Column(TypeName="ntext")]
        public string? Description { get; set; }
        [Column(TypeName ="varbinary")]
        public byte[]? Picture { get; set; }

        public string? PictureMimeType { get; set; }
        

    }
}
