using System;
namespace 
{
	/// <summary>
	/// 餐厅环境介绍
	/// </summary>
	public  class restaurantenvironmentController:Controller
	{
		D_restaurantenvironment drestaurantenvironment = new D_restaurantenvironment();
		/// <summary>
		/// 餐厅环境介绍 列表
		/// </summary>
		public ActionResult restaurantenvironmentList(tb_restaurantenvironment model)
		{
			int count = 0;
			ViewBag.list = dtb_restaurantenvironment.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 餐厅环境介绍 保存
		/// </summary>
		public bool restaurantenvironmentSave(tb_restaurantenvironment model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return drestaurantenvironment.Update(model);
			}
			return drestaurantenvironment.Add(model)>0;
		}

		/// <summary>
		/// 餐厅环境介绍 删除
		/// </summary>
		public bool restaurantenvironmentDelete(tb_restaurantenvironment model)
		{
			return drestaurantenvironment.Delete(model);
		}

		/// <summary>
		/// 餐厅环境介绍 详情
		/// </summary>
		public ActionResult restaurantenvironmentInfo(tb_restaurantenvironment model)
		{
			ViewBag.Info = drestaurantenvironment.GetInfo(model);
			return View();
		}

	}
}

