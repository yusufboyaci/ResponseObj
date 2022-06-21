using Microsoft.AspNetCore.Mvc;
using ResponseObj.Models;
using ResponseObj.Models.ViewModels;

namespace ResponseObj.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Save(AuthorModel author)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                //kayıt işlemi yapılır.
                operationResult.ResultType = OperationResultType.Success;
                operationResult.Message = Messages.Success;
                
            }
            catch (Exception)
            {
                operationResult.ResultType = OperationResultType.Fail;
                operationResult.Message = Messages.Error;
            }
            return Json(operationResult);
        }
    }
}
