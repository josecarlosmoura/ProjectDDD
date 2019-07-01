using AutoMapper;
using DDDApplication.Application.Interface;
using DDDApplication.Domain.Entites;
using DDDApplication.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DDDApplication.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductAppService _productAppService;
        private readonly ICustomerAppService _customerAppService;

        public ProductsController(IProductAppService productAppService, ICustomerAppService customerAppService)
        {
            _productAppService = productAppService;
            _customerAppService = customerAppService
;        }

        // GET: Products
        public ActionResult Index()
        {
            var productModelView = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_productAppService.GetAll());

            return View(productModelView);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            var productModelView = Mapper.Map<Product, ProductViewModel>(_productAppService.GetById(id));

            return View(productModelView);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(_customerAppService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var productDomain = Mapper.Map<ProductViewModel, Product>(productViewModel);
                _productAppService.Add(productDomain);

                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(_customerAppService.GetAll(), "Id", "Name", productViewModel.Id);
            return View(productViewModel);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _productAppService.GetById(id);

            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);

            ViewBag.CustomerId = new SelectList(_customerAppService.GetAll(), "Id", "Name", productViewModel.Id);

            return View(productViewModel);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var productDomain = Mapper.Map<ProductViewModel, Product>(productViewModel);
                _productAppService.Update(productDomain);

                return RedirectToAction("Index");
            }

            return View(productViewModel);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _productAppService.GetById(id);
            var productModelView = Mapper.Map<Product, ProductViewModel>(product);

            return View(productModelView);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = _productAppService.GetById(id);
            _productAppService.Delete(product);
            return RedirectToAction("Index");
        }        
    }
}
