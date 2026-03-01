using System.ComponentModel.DataAnnotations;

namespace jjodel_persistence.Models.Dto {
    public class CreateProjectTemplateRequest {

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

        public string Version { get; set; }
    }
}
