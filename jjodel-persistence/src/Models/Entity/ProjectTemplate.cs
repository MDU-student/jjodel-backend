using System.ComponentModel.DataAnnotations;

namespace jjodel_persistence.Models.Entity {
    public class ProjectTemplate {

        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string State { get; set; } // project content

        [Required]
        public double ViewpointsNumber { get; set; } // relationship?

        [Required]
        public double MetamodelsNumber { get; set; } // relationship?

        [Required]
        public double ModelsNumber { get; set; } // relationship?

        public DateTime Creation { get; set; }
        public DateTime LastModified { get; set; }

        public string Version { get; set; }


    }
}
