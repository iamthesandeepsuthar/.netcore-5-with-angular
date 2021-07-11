using System;
using System.Collections.Generic;

#nullable disable

namespace prj.Data.Models
{
    public partial class TblUserMaster
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DateofBirth { get; set; }
    }
}
