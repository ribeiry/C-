using System.Web.Mvc;
using firstAppOfMVC.Models;

namespace firstAppOfMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario

        private static Usuario _usuarios = new Usuario();

        public ActionResult Index()
        {
            return View(_usuarios.listaUsuarios);
        }
        public ActionResult AdicionaUsuario()
        {
            return View();
        }
        public ActionResult AtualizaUsuario()
        {

           return View();
        }
        [HttpPost]
        public ActionResult AtualizaUsuario(UsuarioModel _usuario)
        {
            _usuarios.AtualizaUsuario(_usuario);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(UsuarioModel _usuarioModel)
        {

            _usuarios.CriarUsuario(_usuarioModel);
            // return View();
            return RedirectToAction("Index");


        }
        public ViewResult DeletaUsuario(string email)
        {
            return View(_usuarios.GetUsuario(email));
        }
        [HttpPost]
        public RedirectToRouteResult DeletaUsuario(string id,FormCollection collection)
        {
            _usuarios.DeletarUsuario(id);
            return RedirectToAction("Index");
        }
    }
}