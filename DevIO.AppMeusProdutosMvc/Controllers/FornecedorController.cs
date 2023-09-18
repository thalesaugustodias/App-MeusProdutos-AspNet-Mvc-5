using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Fornecedores.Services;
using DevIO.Infra.Data.Repository;
using System.Web.Mvc;

namespace DevIO.AppMeusProdutosMvc.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController()
        {
            _fornecedorService = new FornecedorService(new FornecedorRepository(), new EnderecoRepository());
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}