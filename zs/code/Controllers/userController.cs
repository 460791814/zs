using System;
namespace 
{
	/// <summary>
	/// 客户表
	/// </summary>
	public  class userController:Controller
	{
		D_user duser = new D_user();
		/// <summary>
		/// 客户表 列表
		/// </summary>
		public ActionResult userList(tb_user model)
		{
			int count = 0;
			ViewBag.list = dtb_user.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 客户表 保存
		/// </summary>
		public bool userSave(tb_user model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return duser.Update(model);
			}
			return duser.Add(model)>0;
		}

		/// <summary>
		/// 客户表 删除
		/// </summary>
		public bool userDelete(tb_user model)
		{
			return duser.Delete(model);
		}

		/// <summary>
		/// 客户表 详情
		/// </summary>
		public ActionResult userInfo(tb_user model)
		{
			ViewBag.Info = duser.GetInfo(model);
			return View();
		}

	}
}

