using System;
namespace 
{
	/// <summary>
	/// ��������
	/// </summary>
	public  class statusController:Controller
	{
		D_status dstatus = new D_status();
		/// <summary>
		/// �������� �б�
		/// </summary>
		public ActionResult statusList(tb_status model)
		{
			int count = 0;
			ViewBag.list = dtb_status.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public bool statusSave(tb_status model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dstatus.Update(model);
			}
			return dstatus.Add(model)>0;
		}

		/// <summary>
		/// �������� ɾ��
		/// </summary>
		public bool statusDelete(tb_status model)
		{
			return dstatus.Delete(model);
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public ActionResult statusInfo(tb_status model)
		{
			ViewBag.Info = dstatus.GetInfo(model);
			return View();
		}

	}
}

