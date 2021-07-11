using System;
using System.Collections.Generic;

#nullable disable

namespace prj.Data.Models
{
    public partial class TblMasterType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        public string Description { get; set; }
    }
}
