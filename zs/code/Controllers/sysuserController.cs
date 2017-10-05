using System;
namespace 
{
	/// <summary>
	/// 系统用户
	/// </summary>
	public  class sysuserController:Controller
	{
		D_sysuser dsysuser = new D_sysuser();
		/// <summary>
		/// 系统用户 列表
		/// </summary>
		public ActionResult sysuserList(tb_sysuser model)
		{
			int count = 0;
			ViewBag.list = dtb_sysuser.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 系统用户 保存
		/// </summary>
		public bool sysuserSave(tb_sysuser model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dsysuser.Update(model);
			}
			return dsysuser.Add(model)>0;
		}

		/// <summary>
		/// 系统用户 删除
		/// </summary>
		public bool sysuserDelete(tb_sysuser model)
		{
			return dsysuser.Delete(model);
		}

		/// <summary>
		/// 系统用户 详情
		/// </summary>
		public ActionResult sysuserInfo(tb_sysuser model)
		{
			ViewBag.Info = dsysuser.GetInfo(model);
			return View();
		}

	}
}

