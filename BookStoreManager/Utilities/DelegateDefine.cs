using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManage.Utilities
{
    public delegate void clickToAddStockHandler(TypeOfBooks book);
    public delegate void SwitchViewHandler(int id);
    public delegate void CloseFormHandler();
    public delegate void ChangeImageToNoneHandler();
    public delegate void SaveBillHandler(DataTable table, int sum, double discount); 
}
