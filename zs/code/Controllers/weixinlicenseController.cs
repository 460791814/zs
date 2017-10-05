using System;
namespace 
{
	/// <summary>
	/// 微信
	/// </summary>
	public  class weixinlicenseController:Controller
	{
		D_weixinlicense dweixinlicense = new D_weixinlicense();
		/// <summary>
		/// 微信 列表
		/// </summary>
		public ActionResult weixinlicenseList(tb_weixinlicense model)
		{
			int count = 0;
			ViewBag.list = dtb_weixinlicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 微信 保存
		/// </summary>
		public bool weixinlicenseSave(tb_weixinlicense model)
		{
			if (model == null)
			{
				return false
			}
			if (model. >0)
			{
				 return dweixinlicense.Update(model);
			}
			return dweixinlicense.Add(model)>0;
		}

		/// <summary>
		/// 微信 删除
		/// </summary>
		public bool weixinlicenseDelete(tb_weixinlicense model)
		{
			return dweixinlicense.Delete(model);
		}

		/// <summary>
		/// 微信 详情
		/// </summary>
		public ActionResult weixinlicenseInfo(tb_weixinlicense model)
		{
			ViewBag.Info = dweixinlicense.GetInfo(model);
			return View();
		}

	}
}

