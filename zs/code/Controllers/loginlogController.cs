using System;
namespace 
{
	/// <summary>
	/// 登陆日志
	/// </summary>
	public  class loginlogController:Controller
	{
		D_loginlog dloginlog = new D_loginlog();
		/// <summary>
		/// 登陆日志 列表
		/// </summary>
		public ActionResult loginlogList(tb_loginlog model)
		{
			int count = 0;
			ViewBag.list = dtb_loginlog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 登陆日志 保存
		/// </summary>
		public bool loginlogSave(tb_loginlog model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dloginlog.Update(model);
			}
			return dloginlog.Add(model)>0;
		}

		/// <summary>
		/// 登陆日志 删除
		/// </summary>
		public bool loginlogDelete(tb_loginlog model)
		{
			return dloginlog.Delete(model);
		}

		/// <summary>
		/// 登陆日志 详情
		/// </summary>
		public ActionResult loginlogInfo(tb_loginlog model)
		{
			ViewBag.Info = dloginlog.GetInfo(model);
			return View();
		}

	}
}

