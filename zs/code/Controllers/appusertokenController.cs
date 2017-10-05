using System;
namespace 
{
	/// <summary>
	/// App用户登陆Token
	/// </summary>
	public  class appusertokenController:Controller
	{
		D_appusertoken dappusertoken = new D_appusertoken();
		/// <summary>
		/// App用户登陆Token 列表
		/// </summary>
		public ActionResult appusertokenList(tb_appusertoken model)
		{
			int count = 0;
			ViewBag.list = dtb_appusertoken.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// App用户登陆Token 保存
		/// </summary>
		public bool appusertokenSave(tb_appusertoken model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dappusertoken.Update(model);
			}
			return dappusertoken.Add(model)>0;
		}

		/// <summary>
		/// App用户登陆Token 删除
		/// </summary>
		public bool appusertokenDelete(tb_appusertoken model)
		{
			return dappusertoken.Delete(model);
		}

		/// <summary>
		/// App用户登陆Token 详情
		/// </summary>
		public ActionResult appusertokenInfo(tb_appusertoken model)
		{
			ViewBag.Info = dappusertoken.GetInfo(model);
			return View();
		}

	}
}

