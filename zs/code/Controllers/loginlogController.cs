using System;
namespace 
{
	/// <summary>
	/// ��½��־
	/// </summary>
	public  class loginlogController:Controller
	{
		D_loginlog dloginlog = new D_loginlog();
		/// <summary>
		/// ��½��־ �б�
		/// </summary>
		public ActionResult loginlogList(tb_loginlog model)
		{
			int count = 0;
			ViewBag.list = dtb_loginlog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��½��־ ����
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
		/// ��½��־ ɾ��
		/// </summary>
		public bool loginlogDelete(tb_loginlog model)
		{
			return dloginlog.Delete(model);
		}

		/// <summary>
		/// ��½��־ ����
		/// </summary>
		public ActionResult loginlogInfo(tb_loginlog model)
		{
			ViewBag.Info = dloginlog.GetInfo(model);
			return View();
		}

	}
}

