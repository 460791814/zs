using System;
namespace 
{
	/// <summary>
	/// ��ҳ �Ƽ�����
	/// </summary>
	public  class _featureController:Controller
	{
		D_tb_feature dtb_feature = new D_tb_feature();
		/// <summary>
		/// ��ҳ �Ƽ����� �б�
		/// </summary>
		public ActionResult   _featureList(tb_feature model)		{
			int count = 0;
			ViewBag.list = dtb_feature.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

