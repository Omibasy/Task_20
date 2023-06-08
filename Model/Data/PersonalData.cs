using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Task_19.Model.Data
{
    public class PersonalData
    {
        public PersonalData() { }

        public int ID { get; set; }

        [ForeignKey("PersonalitiesID")]
        public int ID_Personalitie { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public Personalities PersonalitiesID { get; set; }
    }
}
