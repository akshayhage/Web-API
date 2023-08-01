using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API.Models
{
    public class Villa
    {
        /*
        DatabaseGeneratedOption.Identity : The database generates value when we insert the row.
        Computed :Database generates a value for the property when we insert or update the row.
        None : Database does not generate a value for the property either in insert or in an update
        */
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
