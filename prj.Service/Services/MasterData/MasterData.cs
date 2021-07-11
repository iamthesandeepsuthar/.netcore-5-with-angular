using prj.Data.Models;
using prj.Helper.ServiceHelper.Method;
using prj.Helper.ServiceHelper.Model;
using prj.Helper.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace prj.Helper.Services.MasterData
{
    public class MasterData : BaseService, IMasterData
    {



        private readonly IUnitOfWork _unitOfWork;
        public MasterData(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ServiceResponse<IEnumerable<object>>> GetList()
        {
            try
            {
                var objData = await _unitOfWork.Repository<TblMasterType>().GetAll();
                return CreateResponse(objData as IEnumerable<object>, "Success", true);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
