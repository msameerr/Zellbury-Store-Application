using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Contracts;
using ZellburyStoreApplication.Data;
using ZellburyStoreApplication.Models;

namespace ZellburyStoreApplication.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository repo, IMapper mapper)
        {

            _repo = repo;
            _mapper = mapper;

        }


        // GET: ProductController
        public ActionResult Index()
        {

            var products = _repo.FindAll().ToList();
            var model = _mapper.Map<List<ProductVM>>(products);

            return View(model);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {

            var product = _repo.FindById(id);
            var model = _mapper.Map<ProductVM>(product);

            return View(model);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {



            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductVM model)
        {
            try
            {

                if(!ModelState.IsValid)
                {
                    return View(model);
                }

                var product = _mapper.Map<Product>(model);

                var isSuccess = _repo.Create(product); 

                if(!isSuccess)
                {
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {

            var product = _repo.FindById(id);
            var model = new ProductVM
            {
                Name = product.Name,
                Quantity = product.Quantity,
                Price = product.Price
            };

            return View(model);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductVM model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }

                var changes = _mapper.Map<Product>(model);
                var isSuccess = _repo.Update(changes);

                if(!isSuccess)
                {
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            if (!_repo.isExist(id))
            {
                return RedirectToAction(nameof(Index));
            }

            var product = _repo.FindById(id);
            var model = _mapper.Map<Product>(product);
            var isSuccess = _repo.Delete(model);

            return RedirectToAction(nameof(Index));

        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
