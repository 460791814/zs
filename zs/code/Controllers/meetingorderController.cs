using System;
namespace 
{
	/// <summary>
	/// ������� ����Ԥ������
	/// </summary>
	public  class meetingorderController:Controller
	{
		D_meetingorder dmeetingorder = new D_meetingorder();
		/// <summary>
		/// ������� ����Ԥ������ �б�
		/// </summary>
		public ActionResult meetingorderList(tb_meetingorder model)
		{
			int count = 0;
			ViewBag.list = dtb_meetingorder.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������� ����Ԥ������ ����
		/// </summary>
		public bool meetingorderSave(tb_meetingorder model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dmeetingorder.Update(model);
			}
			return dmeetingorder.Add(model)>0;
		}

		/// <summary>
		/// ������� ����Ԥ������ ɾ��
		/// </summary>
		public bool meetingorderDelete(tb_meetingorder model)
		{
			return dmeetingorder.Delete(model);
		}

		/// <summary>
		/// ������� ����Ԥ������ ����
		/// </summary>
		public ActionResult meetingorderInfo(tb_meetingorder model)
		{
			ViewBag.Info = dmeetingorder.GetInfo(model);
			return View();
		}

	}
}

