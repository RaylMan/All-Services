using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_Services.ViewModels.Admin
{
    public class EquipmentViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string EquipmentType { get; set; }
    }
}
