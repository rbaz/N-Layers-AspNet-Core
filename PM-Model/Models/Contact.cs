using PM_Model.Common;

namespace PM_Model.Models
{
    public class Contact : BaseEntity
    {
        public string Adresse1_line1 { get; set; }
        public string Adresse2_Line2{ get; set; }
        public string City { get; set; }
        public string Code_Postal { get; set; }
        public string State { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

    }
}
