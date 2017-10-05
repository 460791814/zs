using System;
namespace 
{
	/// <summary>
	/// qq
	/// </summary>
	public  class qqlicenseController:Controller
	{
		D_qqlicense dqqlicense = new D_qqlicense();
		/// <summary>
		/// qq 列表
		/// </summary>
		public ActionResult qqlicenseList(tb_qqlicense model)
		{
			int count = 0;
			ViewBag.list = dtb_qqlicense.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// qq 保存
		/// </summary>
		public bool qqlicenseSave(tb_qqlicense model)
		{
			if (model == null)
			{
				return false
			}
			if (model. >0)
			{
				 return dqqlicense.Update(model);
			}
			return dqqlicense.Add(model)>0;
		}

		/// <summary>
		/// qq 删除
		/// </summary>
		public bool qqlicenseDelete(tb_qqlicense model)
		{
			return dqqlicense.Delete(model);
		}

		/// <summary>
		/// qq 详情
		/// </summary>
		public ActionResult qqlicenseInfo(tb_qqlicense model)
		{
			ViewBag.Info = dqqlicense.GetInfo(model);
			return View();
		}

	}
}

