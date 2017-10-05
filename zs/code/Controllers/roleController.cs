using System;
namespace 
{
	/// <summary>
	/// ��ɫ
	/// </summary>
	public  class roleController:Controller
	{
		D_role drole = new D_role();
		/// <summary>
		/// ��ɫ �б�
		/// </summary>
		public ActionResult roleList(tb_role model)
		{
			int count = 0;
			ViewBag.list = dtb_role.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��ɫ ����
		/// </summary>
		public bool roleSave(tb_role model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return drole.Update(model);
			}
			return drole.Add(model)>0;
		}

		/// <summary>
		/// ��ɫ ɾ��
		/// </summary>
		public bool roleDelete(tb_role model)
		{
			return drole.Delete(model);
		}

		/// <summary>
		/// ��ɫ ����
		/// </summary>
		public ActionResult roleInfo(tb_role model)
		{
			ViewBag.Info = drole.GetInfo(model);
			return View();
		}

	}
}

