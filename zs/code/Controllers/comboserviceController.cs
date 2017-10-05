using System;
namespace 
{
	/// <summary>
	/// 套餐服务内容
	/// </summary>
	public  class comboserviceController:Controller
	{
		D_comboservice dcomboservice = new D_comboservice();
		/// <summary>
		/// 套餐服务内容 列表
		/// </summary>
		public ActionResult comboserviceList(tb_comboservice model)
		{
			int count = 0;
			ViewBag.list = dtb_comboservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 套餐服务内容 保存
		/// </summary>
		public bool comboserviceSave(tb_comboservice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcomboservice.Update(model);
			}
			return dcomboservice.Add(model)>0;
		}

		/// <summary>
		/// 套餐服务内容 删除
		/// </summary>
		public bool comboserviceDelete(tb_comboservice model)
		{
			return dcomboservice.Delete(model);
		}

		/// <summary>
		/// 套餐服务内容 详情
		/// </summary>
		public ActionResult comboserviceInfo(tb_comboservice model)
		{
			ViewBag.Info = dcomboservice.GetInfo(model);
			return View();
		}

	}
}

