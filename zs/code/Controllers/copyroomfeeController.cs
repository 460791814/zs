using System;
namespace 
{
	/// <summary>
	/// �շѱ�׼
	/// </summary>
	public  class copyroomfeeController:Controller
	{
		D_copyroomfee dcopyroomfee = new D_copyroomfee();
		/// <summary>
		/// �շѱ�׼ �б�
		/// </summary>
		public ActionResult copyroomfeeList(tb_copyroomfee model)
		{
			int count = 0;
			ViewBag.list = dtb_copyroomfee.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �շѱ�׼ ����
		/// </summary>
		public bool copyroomfeeSave(tb_copyroomfee model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcopyroomfee.Update(model);
			}
			return dcopyroomfee.Add(model)>0;
		}

		/// <summary>
		/// �շѱ�׼ ɾ��
		/// </summary>
		public bool copyroomfeeDelete(tb_copyroomfee model)
		{
			return dcopyroomfee.Delete(model);
		}

		/// <summary>
		/// �շѱ�׼ ����
		/// </summary>
		public ActionResult copyroomfeeInfo(tb_copyroomfee model)
		{
			ViewBag.Info = dcopyroomfee.GetInfo(model);
			return View();
		}

	}
}

