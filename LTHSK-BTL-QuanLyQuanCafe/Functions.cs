using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe
{
    class Functions
    {
        Bus.BillBus billBus = new Bus.BillBus();
        Bus.TableBus tableBus = new Bus.TableBus();
        Bus.BillinforBus billinforBus = new Bus.BillinforBus();
        public bool checkEmpty(string txt)
        {
            if (txt.Length > 0)
            {
                return true;
            }
            return false;
        }
        public void orderDrinks(string table_id, string drinks_id, string user_id, string soluong)
        {
            if (int.Parse(billBus.getBill_id(table_id)) < 0)
            {
                if(billBus.insertBill(user_id, table_id) && tableBus.updateTableStatus(table_id,"1"))
                {
                    string bill_id = billBus.getBill_id(table_id);
                    if (bill_id != "")
                    {
                        if(billinforBus.insertBillinfor(bill_id, drinks_id,soluong))
                        {
                        }
                    }
                }
            }
            else
            {
                int bill_id = int.Parse(billBus.getBill_id(table_id));
                if (bill_id >=0 )
                {
                    if (billinforBus.insertBillinfor(bill_id.ToString(), drinks_id, soluong))
                    {
                    }
                }
            }
        }

        public bool payment_bill(string bill_id, string table_id, string tortal)
        {
            if(billBus.updateBillStatus(tortal, bill_id) && tableBus.updateTableStatus(table_id,"0"))
            {
                return true;
            }
            return false;
        }
    }
}
