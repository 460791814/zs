using System;
namespace 
{
	/// <summary>
	/// 意见反馈
	/// </summary>
	public  class opinionController:Controller
	{
		D_opinion dopinion = new D_opinion();
		/// <summary>
		/// 意见反馈 列表
		/// </summary>
		public ActionResult opinionList(tb_opinion model)
		{
			int count = 0;
			ViewBag.list = dtb_opinion.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 意见反馈 保存
		/// </summary>
		public bool opinionSave(tb_opinion model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dopinion.Update(model);
			}
			return dopinion.Add(model)>0;
		}

		/// <summary>
		/// 意见反馈 删除
		/// </summary>
		public bool opinionDelete(tb_opinion model)
		{
			return dopinion.Delete(model);
		}

		/// <summary>
		/// 意见反馈 详情
		/// </summary>
		public ActionResult opinionInfo(tb_opinion model)
		{
			ViewBag.Info = dopinion.GetInfo(model);
			return View();
		}

	}
}

