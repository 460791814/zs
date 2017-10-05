using System;
namespace 
{
	/// <summary>
	/// 操作日志
	/// </summary>
	public  class operationlogController:Controller
	{
		D_operationlog doperationlog = new D_operationlog();
		/// <summary>
		/// 操作日志 列表
		/// </summary>
		public ActionResult operationlogList(tb_operationlog model)
		{
			int count = 0;
			ViewBag.list = dtb_operationlog.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 操作日志 保存
		/// </summary>
		public bool operationlogSave(tb_operationlog model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return doperationlog.Update(model);
			}
			return doperationlog.Add(model)>0;
		}

		/// <summary>
		/// 操作日志 删除
		/// </summary>
		public bool operationlogDelete(tb_operationlog model)
		{
			return doperationlog.Delete(model);
		}

		/// <summary>
		/// 操作日志 详情
		/// </summary>
		public ActionResult operationlogInfo(tb_operationlog model)
		{
			ViewBag.Info = doperationlog.GetInfo(model);
			return View();
		}

	}
}

