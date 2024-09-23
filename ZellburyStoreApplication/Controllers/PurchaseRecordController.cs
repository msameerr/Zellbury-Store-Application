using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Contracts;
using Microsoft.AspNetCore.Identity;
using ZellburyStoreApplication.Models;
using ZellburyStoreApplication.Data;
using Microsoft.AspNetCore.Authorization;

namespace ZellburyStoreApplication.Controllers
{
    [Authorize]
    public class PurchaseRecordController : Controller
    {

        private readonly IProductRepository _productRepo;
        private readonly IPurchaseRecordRepository _purchaseRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<Customer> _userManager;

        public PurchaseRecordController(IProductRepository productRepo, IPurchaseRecordRepository purchaseRepo,
           IMapper mapper, UserManager<Customer> userManager)
        {
            _productRepo = productRepo;
            _purchaseRepo = purchaseRepo;
            _mapper = mapper;
            _userManager = userManager;
        }


        // GET: PurchaseRecordController
        public ActionResult Index()
        {

            var products = _productRepo.FindAll().ToList();
            var model = _mapper.Map<List<ProductVM>>(products);

            return View(model);
        }

        public ActionResult Cart(int id)
        {

            var user = _userManager.GetUserAsync(User).Result;
            var Customerid = user.Id;

            var purchase = new PurchaseRecordVM
            {
                DateCreated = DateTime.Now,
                Period = DateTime.Now.Year,
                CustomerId = Customerid,
                ProductId = id
            };


            var model = _mapper.Map<PurchaseRecord>(purchase);
            _purchaseRepo.Create(model);

            return RedirectToAction(nameof(Index));
        }

        // GET: PurchaseRecordController/Details/5
        public ActionResult Details()
        {

            var user = _userManager.GetUserAsync(User).Result;
            var Customerid = user.Id;

            var products = _purchaseRepo.GetProductByCustomer(Customerid).ToList();
            var model = _mapper.Map<List<PurchaseRecordVM>>(products);

            return View(model);
        }

        // GET: PurchaseRecordController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurchaseRecordController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PurchaseRecordController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PurchaseRecordController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: PurchaseRecordController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PurchaseRecordController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
