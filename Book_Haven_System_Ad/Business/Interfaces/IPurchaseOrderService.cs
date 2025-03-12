using Book_Haven__Application.Data.Models;
using Book_Haven_System_Ad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Business.Interfaces
{
    internal interface IPurchaseOrderService
    {
        bool CreatePurchaseOrder(PurchaseOrderModel order, List<PurchaseOrderDetailsModel> orderDetails);
        List<PurchaseOrderModel> GetAllPurchaseOrders();
        bool UpdatePurchaseOrderStatus(Guid purchaseOrderID, string newStatus);



    }
}
