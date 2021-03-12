using System.Collections.Generic;
using Dale.Domain;
using Dale.Infraestructure.Definitions;
using Dale.Infraestructure.Definitions.Context;
using System.Linq;
namespace Dale.Infraestructure.Implementations
{
    internal class BillDetailRepository : RepositoryBase<BillDetail>, IBillDetailRepository
    {
        private readonly IDaleContext _daleContext;
        public BillDetailRepository(IDaleContext daleContext) : base(daleContext)
        {
            _daleContext = daleContext;
        }

        public List<BillDetailDto> GetDetailDto(int idBill)
        {
            var details = (from detail in _daleContext.BillDetails
                           join product in _daleContext.Products on detail.ProductId equals product.Id
                           where detail.BillId == idBill
                           select new BillDetailDto
                           {
                               BillId = idBill,
                               Ammount = detail.Ammount,
                               Id = detail.Id,
                               ProductId = product.Id,
                               ProductName = product.Name, 
                               ProductCost = product.Cost
                           });

            return details.ToList();
        }
    }
}
