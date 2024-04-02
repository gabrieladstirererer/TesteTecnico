using ContatoPerson.Context;
using ContatoPerson.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace ContatoPerson.Controllers
{
    public class FuncionarioController : Controller
    {
        // passando o contexto 
        private readonly FuncionarioContext _funcionario;

        public FuncionarioController(FuncionarioContext funcionario)
        {
            _funcionario = funcionario;
        }
        public IActionResult Index()
        {
            // listar funcionarios 
            var funcionarioList = _funcionario.funcionario.ToList();
            return View(funcionarioList);
        }


        public IActionResult FuncionarioView()
        {
            return View();
        }

        public IActionResult Funcionario(Funcionario funcionario)
        {

            if (ModelState.IsValid)
            {
            _funcionario.Add(funcionario);
            _funcionario.SaveChanges();
            return RedirectToAction(nameof(Index));
            }
            return View(funcionario);

        }

    }
}

