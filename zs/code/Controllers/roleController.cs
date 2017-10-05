using System;
namespace 
{
	/// <summary>
	/// 角色
	/// </summary>
	public  class roleController:Controller
	{
		D_role drole = new D_role();
		/// <summary>
		/// 角色 列表
		/// </summary>
		public ActionResult roleList(tb_role model)
		{
			int count = 0;
			ViewBag.list = dtb_role.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 角色 保存
		/// </summary>
		public bool roleSave(tb_role model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return drole.Update(model);
			}
			return drole.Add(model)>0;
		}

		/// <summary>
		/// 角色 删除
		/// </summary>
		public bool roleDelete(tb_role model)
		{
			return drole.Delete(model);
		}

		/// <summary>
		/// 角色 详情
		/// </summary>
		public ActionResult roleInfo(tb_role model)
		{
			ViewBag.Info = drole.GetInfo(model);
			return View();
		}

	}
}

