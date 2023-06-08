using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Task_19.Model.Data
{
    public class Personalities
    {
        public Personalities() { }

        [Key]
        public int ID { get; set; }

        [StringLength(20)]
        public string Surname { get; set; }

    
        [StringLength(20)]
        public string Name { get; set; }

     
        [StringLength(20)]
        public string Patomic { get; set; }
    }
}
