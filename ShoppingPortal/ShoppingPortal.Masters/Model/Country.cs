using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingPortal.Masters.Model
{
    public class Country
    {
        public int Id { get; set; }


        public Guid CountryId { get; set; }


        public string Name { get; set; }


        public string HostIp { get; set; }


        public Guid? CreatedBy { get; set; }


        public DateTime? CreationDate { get; set; }


        public Guid? UpdatedBy { get; set; }


        public DateTime? UpdatedDate { get; set; }


        public bool? IsActive { get; set; }


        public bool? IsDeleted { get; set; }
    }
}
