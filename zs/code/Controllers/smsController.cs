using System;
namespace 
{
	/// <summary>
	/// �ֻ�������֤��
	/// </summary>
	public  class smsController:Controller
	{
		D_sms dsms = new D_sms();
		/// <summary>
		/// �ֻ�������֤�� �б�
		/// </summary>
		public ActionResult smsList(tb_sms model)
		{
			int count = 0;
			ViewBag.list = dtb_sms.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �ֻ�������֤�� ����
		/// </summary>
		public bool smsSave(tb_sms model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dsms.Update(model);
			}
			return dsms.Add(model)>0;
		}

		/// <summary>
		/// �ֻ�������֤�� ɾ��
		/// </summary>
		public bool smsDelete(tb_sms model)
		{
			return dsms.Delete(model);
		}

		/// <summary>
		/// �ֻ�������֤�� ����
		/// </summary>
		public ActionResult smsInfo(tb_sms model)
		{
			ViewBag.Info = dsms.GetInfo(model);
			return View();
		}

	}
}

