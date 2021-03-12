using System.Collections.Generic;
using Dale.Domain;

namespace Dale.ApplicationServices.Definitions
{
    public interface IBillService : ICrudEntity<Bill>
    {
        List<BillDetailDto> CreateDetail(int idBill,List<BillDetail> details);
    }
}
