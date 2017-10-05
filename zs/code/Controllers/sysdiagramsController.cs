using System;
namespace 
{
	/// <summary>
	/// 1
	/// </summary>
	public  class sysdiagramsController:Controller
	{
		D_sysdiagrams dsysdiagrams = new D_sysdiagrams();
		/// <summary>
		/// 1 列表
		/// </summary>
		public ActionResult sysdiagramsList(sysdiagrams model)
		{
			int count = 0;
			ViewBag.list = dsysdiagrams.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 1 保存
		/// </summary>
		public bool sysdiagramsSave(sysdiagrams model)
		{
			if (model == null)
			{
				return false
			}
			if (model.name >0)
			{
				 return dsysdiagrams.Update(model);
			}
			return dsysdiagrams.Add(model)>0;
		}

		/// <summary>
		/// 1 删除
		/// </summary>
		public bool sysdiagramsDelete(sysdiagrams model)
		{
			return dsysdiagrams.Delete(model);
		}

		/// <summary>
		/// 1 详情
		/// </summary>
		public ActionResult sysdiagramsInfo(sysdiagrams model)
		{
			ViewBag.Info = dsysdiagrams.GetInfo(model);
			return View();
		}

	}
}

