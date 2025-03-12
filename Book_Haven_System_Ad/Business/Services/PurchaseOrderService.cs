using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Business.Interfaces;
using Book_Haven_System_Ad.Data.Models;
using Book_Haven_System_Ad.Data.Repository;
using Book_Haven_System_Ad.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Business.Services
{
    internal class PurchaseOrderService :IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;

        public PurchaseOrderService()
        {
            _purchaseOrderRepository = new PurchaseRepository();
        }

        public bool CreatePurchaseOrder(PurchaseOrderModel order, List<PurchaseOrderDetailsModel> orderDetails)
        {
            return _purchaseOrderRepository.CreatePurchaseOrder(order, orderDetails);
        }

        public List<PurchaseOrderModel> GetAllPurchaseOrders()
        {
            return _purchaseOrderRepository.GetAllPurchaseOrders();
        }
        public bool UpdatePurchaseOrderStatus(Guid purchaseOrderID, string newStatus)
        {
            return _purchaseOrderRepository.UpdatePurchaseOrderStatus(purchaseOrderID, newStatus);
        }

    }
}
