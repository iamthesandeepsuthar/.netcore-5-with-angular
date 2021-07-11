using prj.Helper.ServiceHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Helper.Services.MasterData
{
   public interface IMasterData
    {

        Task<ServiceResponse<IEnumerable<object>>> GetList();
    }
}
