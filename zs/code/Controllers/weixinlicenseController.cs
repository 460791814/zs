using System;
namespace 
{
	/// <summary>
	/// ΢��
	/// </summary>
	public  class weixinlicenseController:Controller
	{
		D_weixinlicense dweixinlicense = new D_weixinlicense();
		/// <summary>
		/// ΢�� �б�
		/// </summary>
		public ActionResult weixinlicenseList(tb_weixinlicense model)
		{
			int count = 0;
			ViewBag.list = dtb_weixinlicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ΢�� ����
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
		/// ΢�� ɾ��
		/// </summary>
		public bool weixinlicenseDelete(tb_weixinlicense model)
		{
			return dweixinlicense.Delete(model);
		}

		/// <summary>
		/// ΢�� ����
		/// </summary>
		public ActionResult weixinlicenseInfo(tb_weixinlicense model)
		{
			ViewBag.Info = dweixinlicense.GetInfo(model);
			return View();
		}

	}
}

