using System;
using System.Collections.Generic;
using System.Text;
using Dale.Domain;

namespace Dale.Infraestructure.Definitions
{
    public interface IBillDetailRepository : IRepositoryBase<BillDetail>
    {
        List<BillDetailDto> GetDetailDto(int idBill);
    }
}
