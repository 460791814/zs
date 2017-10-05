using System;
namespace 
{
	/// <summary>
	/// �ײ�
	/// </summary>
	public  class comboController:Controller
	{
		D_combo dcombo = new D_combo();
		/// <summary>
		/// �ײ� �б�
		/// </summary>
		public ActionResult comboList(tb_combo model)
		{
			int count = 0;
			ViewBag.list = dtb_combo.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �ײ� ����
		/// </summary>
		public bool comboSave(tb_combo model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcombo.Update(model);
			}
			return dcombo.Add(model)>0;
		}

		/// <summary>
		/// �ײ� ɾ��
		/// </summary>
		public bool comboDelete(tb_combo model)
		{
			return dcombo.Delete(model);
		}

		/// <summary>
		/// �ײ� ����
		/// </summary>
		public ActionResult comboInfo(tb_combo model)
		{
			ViewBag.Info = dcombo.GetInfo(model);
			return View();
		}

	}
}

