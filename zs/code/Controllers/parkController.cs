using System;
namespace 
{
	/// <summary>
	/// ��λ��Ϣ
	/// </summary>
	public  class parkController:Controller
	{
		D_park dpark = new D_park();
		/// <summary>
		/// ��λ��Ϣ �б�
		/// </summary>
		public ActionResult parkList(tb_park model)
		{
			int count = 0;
			ViewBag.list = dtb_park.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��λ��Ϣ ����
		/// </summary>
		public bool parkSave(tb_park model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dpark.Update(model);
			}
			return dpark.Add(model)>0;
		}

		/// <summary>
		/// ��λ��Ϣ ɾ��
		/// </summary>
		public bool parkDelete(tb_park model)
		{
			return dpark.Delete(model);
		}

		/// <summary>
		/// ��λ��Ϣ ����
		/// </summary>
		public ActionResult parkInfo(tb_park model)
		{
			ViewBag.Info = dpark.GetInfo(model);
			return View();
		}

	}
}

