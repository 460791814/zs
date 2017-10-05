using System;
namespace 
{
	/// <summary>
	/// ��ӡ���
	/// </summary>
	public  class copyroomController:Controller
	{
		D_copyroom dcopyroom = new D_copyroom();
		/// <summary>
		/// ��ӡ��� �б�
		/// </summary>
		public ActionResult copyroomList(tb_copyroom model)
		{
			int count = 0;
			ViewBag.list = dtb_copyroom.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��ӡ��� ����
		/// </summary>
		public bool copyroomSave(tb_copyroom model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcopyroom.Update(model);
			}
			return dcopyroom.Add(model)>0;
		}

		/// <summary>
		/// ��ӡ��� ɾ��
		/// </summary>
		public bool copyroomDelete(tb_copyroom model)
		{
			return dcopyroom.Delete(model);
		}

		/// <summary>
		/// ��ӡ��� ����
		/// </summary>
		public ActionResult copyroomInfo(tb_copyroom model)
		{
			ViewBag.Info = dcopyroom.GetInfo(model);
			return View();
		}

	}
}

