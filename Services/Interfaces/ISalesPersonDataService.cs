using ISIT420_HW4_Tarasiuk_Gurskaia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Services.Interfaces
{
    interface ISalesPersonDataService
    {
        List<SalesPerson> GetAllSalesPerson();
    }
}
