using...

namespace Nop.WEb.Controllers
{
  [AutoValidateAntiforgeryToken]
    public partial class ProductController : BasePublicController
    {
      Fields
            
      Ctor
      
      Product details page
      
      Recently viewed products
      
      New (recently added) product pge
      
      Product reviews
      
      Email  friend
      
      Comparing products
        
      #region 兌換序號
        [HttpGet]
        public ActionResult RedeemCode(string code)
        {
            string WinCode = "KG777";
            if (code == WinCode)
            {
                var status = new { result = "WIN!!!" };
                return Json(status);
            }
            else
            {
                var status = new { result = "Try Again" };
                return Json(status);
            }
        }
        #endregion
    }
}
