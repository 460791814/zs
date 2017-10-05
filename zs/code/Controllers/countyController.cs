using System;
namespace 
{
	/// <summary>
	/// 县
	/// </summary>
	public  class countyController:Controller
	{
		D_county dcounty = new D_county();
		/// <summary>
		/// 县 列表
		/// </summary>
		public ActionResult countyList(tb_county model)
		{
			int count = 0;
			ViewBag.list = dtb_county.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 县 保存
		/// </summary>
		public bool countySave(tb_county model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcounty.Update(model);
			}
			return dcounty.Add(model)>0;
		}

		/// <summary>
		/// 县 删除
		/// </summary>
		public bool countyDelete(tb_county model)
		{
			return dcounty.Delete(model);
		}

		/// <summary>
		/// 县 详情
		/// </summary>
		public ActionResult countyInfo(tb_county model)
		{
			ViewBag.Info = dcounty.GetInfo(model);
			return View();
		}

	}
}

