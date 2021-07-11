using prj.Helper.ServiceHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj.Helper.ServiceHelper.Method
{
    public class BaseService
    {
        public readonly LoginUserViewModel _loginUserDetail;
        public BaseService()
        {
            _loginUserDetail = new LoginUserViewModel();
        }

        public virtual ServiceResponse<T> CreateResponse<T>(T objData, string Message, bool IsSuccess, string exception = "", string validationMessage = "") where T : class
        {
            ServiceResponse<T> objReturn = new ServiceResponse<T>();
            objReturn.Message = Message;
            objReturn.IsSuccess = IsSuccess;
            objReturn.Data = objData;
            objReturn.Exception = exception;

            return objReturn;
        }

        public class LoginUserViewModel
        {
            public int UserId { get; set; }
            public int UserTypeId { get; set; }
            public string UserType { get; set; }
            public string BaseUserType { get; set; }
            public string Name { get; set; }


            //public LoginUserViewModel()
            //{
            //    this.UserCode = CurruntUserViewModel.UserCode;
            //    this.UserTypeCode = CurruntUserViewModel.UserTypeCode;
            //    this.UserType = CurruntUserViewModel.UserType;
            //    this.BaseUserType = CurruntUserViewModel.BaseUserType;
            //    this.Name = CurruntUserViewModel.Name;
            //    this.SSOID = CurruntUserViewModel.SSOID;
            //    this.FileSize = CurruntUserViewModel.FileSize;
            //}
        }
    }
}
