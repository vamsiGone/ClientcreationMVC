using System.ComponentModel.DataAnnotations;

namespace ClientCreation.Models
{
    public class RegistrationCheckList
    {
        [Key]
        public int id { get; set; }
        public string HeadingTab { get; set; } = string.Empty;
        public string Field { get; set; } = string.Empty;
        public string ControlType { get; set; } = string.Empty;
        public string DataType { get; set; } = string.Empty;
        public int ControlLength { get; set; }
        public string FieldValue { get; set; } = string.Empty;
        public string IsMandatory { get; set; } = string.Empty;
        public string IsEditable { get; set; } = string.Empty;
        public int ClientId { get; set; }   
        public string ClientName { get; set; } = string.Empty;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
