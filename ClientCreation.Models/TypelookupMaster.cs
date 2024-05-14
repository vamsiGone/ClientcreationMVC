using System.ComponentModel.DataAnnotations;

namespace ClientCreation.Models
{
    public class TypeLookUpMaster
    {
        [Key]
        public int TypeLookID { get; set; }
        [StringLength(200)]
        [Required]
        public string Context { get; set; } = string.Empty;
        public int SequenceNo { get; set; }
        public string ParamID { get; set; } = string.Empty;
        public string ParamDesc { get; set; } = string.Empty;
        public string ParamValue { get; set; } = string.Empty;
        public string AdditionalInfo { get; set; } = string.Empty;
        //public int InstituteID { get; set; }
        //public int Active { get; set; }
        //public int CreatedBy { get; set; }
        //public DateTime CreatedDateTime { get; set; }
        //public int ModifiedBy { get; set; }
        //public DateTime ModifiedDateTime { get; set; }
        //public string F1 { get; set; } = string.Empty;
        //public string F2 { get; set; } = string.Empty;
        //public string F3 { get; set; } = string.Empty;
        //public string F4 { get; set; } = string.Empty;
        //public string F5 { get; set; } = string.Empty;
    }
}
