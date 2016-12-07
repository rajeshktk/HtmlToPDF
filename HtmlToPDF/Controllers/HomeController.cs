
using SelectPdf;
using System.Web.Mvc;

namespace HtmlToPDF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult RajeshCV()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public void ToPDF()
        {
            string url = "http://localhost:64501/Home/RajeshCV";
            string file = @"\\global.tesco.org\dfsroot\IN\HeadOffice\Home\BLR01\IS36\Desktop\Rajesh.pdf";

            HtmlToPdf converter = new HtmlToPdf();
            // convert the url to pdf
            PdfDocument doc = converter.ConvertUrl(url);

            // save pdf document
            doc.Save(file);

            // close pdf document
            doc.Close();
          
        }
    }
}