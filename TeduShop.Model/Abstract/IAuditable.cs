using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        DateTime? CreatedDate { get; set; }
        string Createdby { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

        bool Status { get; set; }

    }
}
