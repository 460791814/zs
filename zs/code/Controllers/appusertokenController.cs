using System;
namespace 
{
	/// <summary>
	/// App�û���½Token
	/// </summary>
	public  class appusertokenController:Controller
	{
		D_appusertoken dappusertoken = new D_appusertoken();
		/// <summary>
		/// App�û���½Token �б�
		/// </summary>
		public ActionResult appusertokenList(tb_appusertoken model)
		{
			int count = 0;
			ViewBag.list = dtb_appusertoken.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// App�û���½Token ����
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
		/// App�û���½Token ɾ��
		/// </summary>
		public bool appusertokenDelete(tb_appusertoken model)
		{
			return dappusertoken.Delete(model);
		}

		/// <summary>
		/// App�û���½Token ����
		/// </summary>
		public ActionResult appusertokenInfo(tb_appusertoken model)
		{
			ViewBag.Info = dappusertoken.GetInfo(model);
			return View();
		}

	}
}

