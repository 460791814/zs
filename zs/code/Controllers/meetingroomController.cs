using System;
namespace 
{
	/// <summary>
	/// �����ҹ���
	/// </summary>
	public  class meetingroomController:Controller
	{
		D_meetingroom dmeetingroom = new D_meetingroom();
		/// <summary>
		/// �����ҹ��� �б�
		/// </summary>
		public ActionResult meetingroomList(tb_meetingroom model)
		{
			int count = 0;
			ViewBag.list = dtb_meetingroom.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �����ҹ��� ����
		/// </summary>
		public bool meetingroomSave(tb_meetingroom model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dmeetingroom.Update(model);
			}
			return dmeetingroom.Add(model)>0;
		}

		/// <summary>
		/// �����ҹ��� ɾ��
		/// </summary>
		public bool meetingroomDelete(tb_meetingroom model)
		{
			return dmeetingroom.Delete(model);
		}

		/// <summary>
		/// �����ҹ��� ����
		/// </summary>
		public ActionResult meetingroomInfo(tb_meetingroom model)
		{
			ViewBag.Info = dmeetingroom.GetInfo(model);
			return View();
		}

	}
}

