using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dale.ApplicationServices.Definitions;
using Dale.Domain;
using Dale.Infraestructure.Definitions;

namespace Dale.ApplicationServices.Implementations
{
    internal class BillService : IBillService
    {
        private readonly IBillRepository _billRepository;
        private readonly IBillDetailRepository _billDetailRepository;

        public BillService(IBillRepository billRepository, IBillDetailRepository billDetailRepository)
        {
            _billRepository = billRepository;
            _billDetailRepository = billDetailRepository;
        }

        public Bill Create(Bill bill)
        {
            _billRepository.Create(bill);
            return bill;
        }

        public List<BillDetailDto> CreateDetail(int idBill, List<BillDetail> details)
        {
            List<BillDetail> existsDetail = _billDetailRepository.GetBy(x => x.BillId == idBill).ToList();

            foreach (var item in existsDetail)
            {
                _billDetailRepository.Delete(item);
            }

            foreach (var item in details)
            {
                _billDetailRepository.Create(item);
            }

            return _billDetailRepository.GetDetailDto(idBill);

        }

        public bool Delete(int billId)
        {
            bool result = false;
            Bill bill = Get(billId);

            if (bill != null)
            {
                _billRepository.Delete(bill);
                result = true;
            }
            return result;
        }

        public Bill Get(int billId)
        {
            Bill bill = null;
            bill = _billRepository.GetBy(x => x.Id == billId).FirstOrDefault();
            return bill;
        }

        public IEnumerable<Bill> GetList()
        {
            return _billRepository.GetAll();
        }

        public Bill Update(Bill bill)
        {
            _billRepository.Update(bill);
            return bill;
        }
    }
}
