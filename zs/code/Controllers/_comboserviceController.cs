using System;
namespace 
{
	/// <summary>
	/// 套餐服务内容
	/// </summary>
	public  class _comboserviceController:Controller
	{
		D_tb_comboservice dtb_comboservice = new D_tb_comboservice();
		/// <summary>
		/// 套餐服务内容 列表
		/// </summary>
		public ActionResult   _comboserviceList(tb_comboservice model)		{
			int count = 0;
			ViewBag.list = dtb_comboservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

