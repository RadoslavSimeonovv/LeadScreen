namespace LeadScreen.Data.Entities
{
    using LeadScreen.Data.Entities.Common;
    using System.Collections.Generic;

    public class Subarea : BaseEntity
    {
        public string Name { get; set; }
        public string Pincode { get; set; }
        public ICollection<Lead> Leads { get; set; }

    }
}
