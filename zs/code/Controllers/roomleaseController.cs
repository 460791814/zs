using System;
namespace 
{
	/// <summary>
	/// �������
	/// </summary>
	public  class roomleaseController:Controller
	{
		D_roomlease droomlease = new D_roomlease();
		/// <summary>
		/// ������� �б�
		/// </summary>
		public ActionResult roomleaseList(tb_roomlease model)
		{
			int count = 0;
			ViewBag.list = dtb_roomlease.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������� ����
		/// </summary>
		public bool roomleaseSave(tb_roomlease model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droomlease.Update(model);
			}
			return droomlease.Add(model)>0;
		}

		/// <summary>
		/// ������� ɾ��
		/// </summary>
		public bool roomleaseDelete(tb_roomlease model)
		{
			return droomlease.Delete(model);
		}

		/// <summary>
		/// ������� ����
		/// </summary>
		public ActionResult roomleaseInfo(tb_roomlease model)
		{
			ViewBag.Info = droomlease.GetInfo(model);
			return View();
		}

	}
}

