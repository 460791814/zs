using System;
namespace 
{
	/// <summary>
	/// 餐厅环境介绍
	/// </summary>
	public  class _restaurantenvironmentController:Controller
	{
		D_tb_restaurantenvironment dtb_restaurantenvironment = new D_tb_restaurantenvironment();
		/// <summary>
		/// 餐厅环境介绍 列表
		/// </summary>
		public ActionResult   _restaurantenvironmentList(tb_restaurantenvironment model)		{
			int count = 0;
			ViewBag.list = dtb_restaurantenvironment.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

