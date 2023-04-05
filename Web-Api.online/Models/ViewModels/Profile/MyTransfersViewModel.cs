using System.Collections.Generic;
using Web_Api.online.Models.Tables;

namespace Web_Api.online.Models.ViewModels.Profile
{
    public class MyTransfersViewModel
    {
        public List<spGetTransfersByUser_Paged> Transfers { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public int ItemsCount { get; set; }
    }
}
