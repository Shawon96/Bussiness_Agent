using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Agent.Core.Entities
{
    [Table("BusinessEntities")]
    public class BusinessEntities
    {
        public int BusinessId { set; get; }
        public string Code { set; get; }
        public string Email { set; get; }
        public string Name { set; get; }
        public string Street { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Zip { set; get; }
        public string Country { set; get; }
        public string Mobile { set; get; }
        public string Phone { set; get; }
        public string ContactPerson { set; get; }
        public string ReferredBy { set; get; }
        public string Logo { set; get; }
        public int Status { set; get; }
        public long Balance { set; get; }
        public string LoginUrl { set; get; }
        public string SecurityCode { set; get; }
        public string SMTPServer { set; get; }
        public int SMTPPort { set; get; }
        public string SMTPUsername { set; get; }
        public string SMTPPassword { set; get; }
        public bool Deleted { set; get; }
        public DateTime? CreatedOnUtc { set; get; }
        public DateTime? UpdatedOnUtc { set; get; }
        public long CurrentBalance { set; get; }
    }
}
