using System;
namespace 
{
	/// <summary>
	/// ÖÜ±ßÅäÌ×½éÉÜ
	/// </summary>
	public  class housearoundController:Controller
	{
		D_housearound dhousearound = new D_housearound();
		/// <summary>
		/// ÖÜ±ßÅäÌ×½éÉÜ ÁĞ±í
		/// </summary>
		public ActionResult housearoundList(tb_housearound model)
		{
			int count = 0;
			ViewBag.list = dtb_housearound.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ÖÜ±ßÅäÌ×½éÉÜ ±£´æ
		/// </summary>
		public bool housearoundSave(tb_housearound model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dhousearound.Update(model);
			}
			return dhousearound.Add(model)>0;
		}

		/// <summary>
		/// ÖÜ±ßÅäÌ×½éÉÜ É¾³ı
		/// </summary>
		public bool housearoundDelete(tb_housearound model)
		{
			return dhousearound.Delete(model);
		}

		/// <summary>
		/// ÖÜ±ßÅäÌ×½éÉÜ ÏêÇé
		/// </summary>
		public ActionResult housearoundInfo(tb_housearound model)
		{
			ViewBag.Info = dhousearound.GetInfo(model);
			return View();
		}

	}
}

