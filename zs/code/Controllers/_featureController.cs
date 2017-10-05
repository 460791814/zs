using System;
namespace 
{
	/// <summary>
	/// 首页 推荐内容
	/// </summary>
	public  class _featureController:Controller
	{
		D_tb_feature dtb_feature = new D_tb_feature();
		/// <summary>
		/// 首页 推荐内容 列表
		/// </summary>
		public ActionResult   _featureList(tb_feature model)		{
			int count = 0;
			ViewBag.list = dtb_feature.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

