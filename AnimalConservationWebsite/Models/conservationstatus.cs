using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalConservationWebsite.Models
{
    [Table("conservationstatus")]  
    public class ConservationStatus
    {
        [Key]
        public int status_id { get; set; }

        public string group_name { get; set; }
        public int extinct { get; set; }
        public int extinct_in_wild { get; set; }
        public int subtotal_extinct { get; set; }
        public int critically_endangered_pe { get; set; }
        public int critically_endangered_pew { get; set; }
        public int subtotal_critically_endangered { get; set; }
        public int endangered { get; set; }
        public int vulnerable { get; set; }
        public int subtotal_threatened { get; set; }
        public int lower_risk_conservation_dependent { get; set; }
        public int near_threatened { get; set; }
        public int least_concern { get; set; }
        public int data_deficient { get; set; }
        public int total_species { get; set; }
    }
}
