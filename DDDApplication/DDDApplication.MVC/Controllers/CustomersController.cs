using AutoMapper;
using DDDApplication.Application.Interface;
using DDDApplication.Domain.Entites;
using DDDApplication.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DDDApplication.MVC.Controllers
{
    public class CustomersController : Controller
    {
        //private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly ICustomerAppService _customerAppService;

        public CustomersController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customerViewModel = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(_customerAppService.GetAll());
            return View(customerViewModel);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            var customer = _customerAppService.GetById(id);
            var customerViewModel = Mapper.Map<Customer, CustomerViewModel>(customer);

            return View(customerViewModel);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var customerDomain = Mapper.Map<CustomerViewModel, Customer>(customerViewModel);
                _customerAppService.Add(customerDomain);

                return RedirectToAction("Index");
            }

            return View(customerViewModel);
        }

        public ActionResult Special()
        {
            var customerViewModel = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(_customerAppService.GetSpacialCustomer());

            return View(customerViewModel);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = _customerAppService.GetById(id);
            var customerViewModel = Mapper.Map<Customer, CustomerViewModel>(customer);

            return View(customerViewModel);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                var customerViewModel = Mapper.Map<CustomerViewModel, Customer>(customer);
                _customerAppService.Update(customerViewModel);

                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = _customerAppService.GetById(id);
            var customerViewModel = Mapper.Map<Customer, CustomerViewModel>(customer);

            return View(customerViewModel);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var customer = _customerAppService.GetById(id);
            _customerAppService.Delete(customer);

            return RedirectToAction("Index");
        }

        public ActionResult Search(string nameFragment)
        {
            var teste = _customerAppService.FindCustomersByName(nameFragment);
            var customerViewModel = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(teste);

            return View(customerViewModel);
        }
    }
}
