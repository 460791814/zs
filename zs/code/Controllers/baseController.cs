using System;
namespace 
{
	/// <summary>
	/// ��������
	/// </summary>
	public  class baseController:Controller
	{
		D_base dbase = new D_base();
		/// <summary>
		/// �������� �б�
		/// </summary>
		public ActionResult baseList(tb_base model)
		{
			int count = 0;
			ViewBag.list = dtb_base.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public bool baseSave(tb_base model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dbase.Update(model);
			}
			return dbase.Add(model)>0;
		}

		/// <summary>
		/// �������� ɾ��
		/// </summary>
		public bool baseDelete(tb_base model)
		{
			return dbase.Delete(model);
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public ActionResult baseInfo(tb_base model)
		{
			ViewBag.Info = dbase.GetInfo(model);
			return View();
		}

	}
}

