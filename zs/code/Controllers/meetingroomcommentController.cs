using System;
namespace 
{
	/// <summary>
	/// 会议室评价
	/// </summary>
	public  class meetingroomcommentController:Controller
	{
		D_meetingroomcomment dmeetingroomcomment = new D_meetingroomcomment();
		/// <summary>
		/// 会议室评价 列表
		/// </summary>
		public ActionResult meetingroomcommentList(tb_meetingroomcomment model)
		{
			int count = 0;
			ViewBag.list = dtb_meetingroomcomment.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 会议室评价 保存
		/// </summary>
		public bool meetingroomcommentSave(tb_meetingroomcomment model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dmeetingroomcomment.Update(model);
			}
			return dmeetingroomcomment.Add(model)>0;
		}

		/// <summary>
		/// 会议室评价 删除
		/// </summary>
		public bool meetingroomcommentDelete(tb_meetingroomcomment model)
		{
			return dmeetingroomcomment.Delete(model);
		}

		/// <summary>
		/// 会议室评价 详情
		/// </summary>
		public ActionResult meetingroomcommentInfo(tb_meetingroomcomment model)
		{
			ViewBag.Info = dmeetingroomcomment.GetInfo(model);
			return View();
		}

	}
}

