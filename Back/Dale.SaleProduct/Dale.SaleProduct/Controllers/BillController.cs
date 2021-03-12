using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dale.ApplicationServices.Definitions;
using Dale.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dale.SaleProduct.Controllers
{
    [AllowAnonymous]
    [Route("api/bill")]
    [ApiController]
    public class BillController : Controller
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        [HttpPost]
        public async Task<Bill> CreateBill(Bill createBill)
        {
            Bill bill = null;
            try
            {
                bill = await Task.Run(() => _billService.Create(createBill));
            }
            catch (Exception)
            {

                throw;
            }
            return bill;
        }
        [HttpPut]
        public async Task<Bill> UpdateBill(Bill updateBill)
        {
            Bill bill = null;
            try
            {
                bill = await Task.Run(() => _billService.Update(updateBill));
            }
            catch (System.Exception)
            {

                throw;
            }
            return bill;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> DeleteBill(int id)
        {
            bool result = false;
            try
            {
                result = await Task.Run(() => _billService.Delete(id));
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Bill> Get(int id)
        {
            Bill bills = null;
            try
            {
                bills = await Task.Run(() => _billService.Get(id));
            }
            catch (System.Exception)
            {

                throw;
            }
            return bills;
        }

        [HttpGet]
        public async Task<List<Bill>> GetBills()
        {
            List<Bill> bills = null;
            try
            {
                bills = await Task.Run(() => _billService.GetList().ToList());
            }
            catch (System.Exception)
            {

                throw;
            }
            return bills;
        }

        [HttpPost]
        [Route("{id}/createDetail")]
        public async Task<List<BillDetailDto>> CreateDetail(int id, List<BillDetail> details)
        {
            List<BillDetailDto> bills = null;
            try
            {
                bills = await Task.Run(() => _billService.CreateDetail(id, details));
            }
            catch (System.Exception)
            {
                throw;
            }
            return bills;
        }
    }
}