using GG.CadastroClientesDDD.Application.Interfaces;
using GG.CadastroClientesDDD.Application.ViewModels;
using System;
using System.Net;
using System.Web.Mvc;

namespace GG.CadastroClientesDDD.Presentation.MVC.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomersController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        // GET: Customers
        public ActionResult Index()
        {
            return View(_customerAppService.GetAllCustomersActive());
        }

        // GET: Customers/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerViewModel customerViewModel = _customerAppService.GetById(id);
            if (customerViewModel == null)
            {
                return HttpNotFound();
            }

            return View(customerViewModel);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
         
   return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                customerViewModel = _customerAppService.Add(customerViewModel);

                if (!customerViewModel.ValidationResult.IsValid)
                {
                    foreach (var erro in customerViewModel.ValidationResult.Erros)
                    {
                        ModelState.AddModelError(string.Empty, erro.Message);
                    }
                    return View(customerViewModel);
                }

                return RedirectToAction("Index");
            }

            return View(customerViewModel);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CustomerViewModel customerViewModel = _customerAppService.GetById(id);
            if (customerViewModel == null)
            {
                return HttpNotFound();
            }

            ViewBag.Id = id;

            return View(customerViewModel);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                _customerAppService.Update(customerViewModel);

                return RedirectToAction("Index");
            }

            return View(customerViewModel);
        }

        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CustomerViewModel customer = _customerAppService.GetById(id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _customerAppService.Remove(id);
            return RedirectToAction("Index");
        }


    }
}
