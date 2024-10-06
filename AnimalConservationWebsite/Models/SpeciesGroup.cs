using System.ComponentModel.DataAnnotations;
namespace AnimalConservationWebsite.Models;

public class SpeciesGroup
{
    [Key]  // This marks the primary key of the table
    public int GroupId { get; set; }

    public string GroupName { get; set; }
    public int TotalSpecies { get; set; }
    public int EndangeredSpecies { get; set; } 

}
