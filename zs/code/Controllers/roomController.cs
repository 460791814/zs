using System;
namespace 
{
	/// <summary>
	/// ·¿ÎÝ×âÁÞ
	/// </summary>
	public  class roomController:Controller
	{
		D_room droom = new D_room();
		/// <summary>
		/// ·¿ÎÝ×âÁÞ ÁÐ±í
		/// </summary>
		public ActionResult roomList(tb_room model)
		{
			int count = 0;
			ViewBag.list = dtb_room.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ·¿ÎÝ×âÁÞ ±£´æ
		/// </summary>
		public bool roomSave(tb_room model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droom.Update(model);
			}
			return droom.Add(model)>0;
		}

		/// <summary>
		/// ·¿ÎÝ×âÁÞ É¾³ý
		/// </summary>
		public bool roomDelete(tb_room model)
		{
			return droom.Delete(model);
		}

		/// <summary>
		/// ·¿ÎÝ×âÁÞ ÏêÇé
		/// </summary>
		public ActionResult roomInfo(tb_room model)
		{
			ViewBag.Info = droom.GetInfo(model);
			return View();
		}

	}
}

