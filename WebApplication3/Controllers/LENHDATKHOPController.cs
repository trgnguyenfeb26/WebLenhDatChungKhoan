using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.Dynamic;
using WebApplication3.Models;
using System.Net;

namespace WebApplication3.Controllers
{
    public class LENHDATKHOPController : Controller
    {
        public CKEntities sd = new CKEntities();
        // GET: LENHDATKHOP
        public ActionResult Index()
        {
            dynamic dy = new ExpandoObject();
            dy.LenhDatList = getLenhDat();
            dy.LenhKhopList = getLenhKhop();
            return View(dy);
        }
        public List<LENHDAT> getLenhDat()
        {
            CKEntities sd = new CKEntities();
            List<LENHDAT> LLenhDat = sd.LENHDAT.ToList();
            return LLenhDat;
        }
        public List<LENHKHOP> getLenhKhop()
        {
            CKEntities sd = new CKEntities();
            List<LENHKHOP> LLenhKhop = sd.LENHKHOP.ToList();
            return LLenhKhop;
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LENHDAT lENHDAT = sd.LENHDAT.Find(id);
            if (lENHDAT == null)
            {
                return HttpNotFound();
            }
            return View(lENHDAT);
        }

        // POST: LENHDATs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LENHDAT lENHDAT = sd.LENHDAT.Find(id);
            sd.LENHDAT.Remove(lENHDAT);
            sd.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}