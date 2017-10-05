using System;
namespace 
{
	/// <summary>
	/// ��������
	/// </summary>
	public  class roomController:Controller
	{
		D_room droom = new D_room();
		/// <summary>
		/// �������� �б�
		/// </summary>
		public ActionResult roomList(tb_room model)
		{
			int count = 0;
			ViewBag.list = dtb_room.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public bool roomSave(tb_room model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droom.Update(model);
			}
			return droom.Add(model)>0;
		}

		/// <summary>
		/// �������� ɾ��
		/// </summary>
		public bool roomDelete(tb_room model)
		{
			return droom.Delete(model);
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public ActionResult roomInfo(tb_room model)
		{
			ViewBag.Info = droom.GetInfo(model);
			return View();
		}

	}
}

