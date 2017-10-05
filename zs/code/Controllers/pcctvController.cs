using System;
namespace 
{
	/// <summary>
	/// ʡ������
	/// </summary>
	public  class pcctvController:Controller
	{
		D_pcctv dpcctv = new D_pcctv();
		/// <summary>
		/// ʡ������ �б�
		/// </summary>
		public ActionResult pcctvList(tb_pcctv model)
		{
			int count = 0;
			ViewBag.list = dtb_pcctv.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ʡ������ ����
		/// </summary>
		public bool pcctvSave(tb_pcctv model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dpcctv.Update(model);
			}
			return dpcctv.Add(model)>0;
		}

		/// <summary>
		/// ʡ������ ɾ��
		/// </summary>
		public bool pcctvDelete(tb_pcctv model)
		{
			return dpcctv.Delete(model);
		}

		/// <summary>
		/// ʡ������ ����
		/// </summary>
		public ActionResult pcctvInfo(tb_pcctv model)
		{
			ViewBag.Info = dpcctv.GetInfo(model);
			return View();
		}

	}
}

