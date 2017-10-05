using System;
namespace 
{
	/// <summary>
	/// ���೵�ͳ�λ����
	/// </summary>
	public  class parkspaceController:Controller
	{
		D_parkspace dparkspace = new D_parkspace();
		/// <summary>
		/// ���೵�ͳ�λ���� �б�
		/// </summary>
		public ActionResult parkspaceList(tb_parkspace model)
		{
			int count = 0;
			ViewBag.list = dtb_parkspace.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ���೵�ͳ�λ���� ����
		/// </summary>
		public bool parkspaceSave(tb_parkspace model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dparkspace.Update(model);
			}
			return dparkspace.Add(model)>0;
		}

		/// <summary>
		/// ���೵�ͳ�λ���� ɾ��
		/// </summary>
		public bool parkspaceDelete(tb_parkspace model)
		{
			return dparkspace.Delete(model);
		}

		/// <summary>
		/// ���೵�ͳ�λ���� ����
		/// </summary>
		public ActionResult parkspaceInfo(tb_parkspace model)
		{
			ViewBag.Info = dparkspace.GetInfo(model);
			return View();
		}

	}
}

