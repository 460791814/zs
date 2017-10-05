using System;
namespace 
{
	/// <summary>
	/// 市
	/// </summary>
	public  class cityController:Controller
	{
		D_city dcity = new D_city();
		/// <summary>
		/// 市 列表
		/// </summary>
		public ActionResult cityList(tb_city model)
		{
			int count = 0;
			ViewBag.list = dtb_city.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 市 保存
		/// </summary>
		public bool citySave(tb_city model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcity.Update(model);
			}
			return dcity.Add(model)>0;
		}

		/// <summary>
		/// 市 删除
		/// </summary>
		public bool cityDelete(tb_city model)
		{
			return dcity.Delete(model);
		}

		/// <summary>
		/// 市 详情
		/// </summary>
		public ActionResult cityInfo(tb_city model)
		{
			ViewBag.Info = dcity.GetInfo(model);
			return View();
		}

	}
}

