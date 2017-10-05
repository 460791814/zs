using System;
namespace 
{
	/// <summary>
	/// ʡ
	/// </summary>
	public  class provinceController:Controller
	{
		D_province dprovince = new D_province();
		/// <summary>
		/// ʡ �б�
		/// </summary>
		public ActionResult provinceList(tb_province model)
		{
			int count = 0;
			ViewBag.list = dtb_province.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ʡ ����
		/// </summary>
		public bool provinceSave(tb_province model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dprovince.Update(model);
			}
			return dprovince.Add(model)>0;
		}

		/// <summary>
		/// ʡ ɾ��
		/// </summary>
		public bool provinceDelete(tb_province model)
		{
			return dprovince.Delete(model);
		}

		/// <summary>
		/// ʡ ����
		/// </summary>
		public ActionResult provinceInfo(tb_province model)
		{
			ViewBag.Info = dprovince.GetInfo(model);
			return View();
		}

	}
}

