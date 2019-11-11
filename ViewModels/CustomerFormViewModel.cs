using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Smartmom4.Models;

namespace Smartmom4.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}