using MVC1.Context;
using MVC1.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class ProductController : Controller
    {
        private StoreContext db = new StoreContext();
        
        // GET: Product
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Product/Details/5
        //int? -> acepta valores null
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(1);
            }
            var product = db.Products.Find(id);
            if(product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View(product);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(1, "Product not Found!");
            }
            var product = db.Products.Find(id);
            if(product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(1, "Product not found!");
            }
            var product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);           
        }

        // POST: Product/Delete/5
        //recibe el id y el objeto del producto
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Esto se hace ya que el producto puede llegar con valores nulos
                    product = db.Products.Find(id);
                    if(product == null)
                    {
                        return HttpNotFound();
                    }
                    db.Products.Remove(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(product);               
            }
            catch
            {
                return View(product);
            }
        }
    }
}
