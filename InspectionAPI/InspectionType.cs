using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class InspectionType
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;
    }
}
