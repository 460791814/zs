using System;
namespace 
{
	/// <summary>
	/// 楼层展示图
	/// </summary>
	public  class roomfaceController:Controller
	{
		D_roomface droomface = new D_roomface();
		/// <summary>
		/// 楼层展示图 列表
		/// </summary>
		public ActionResult roomfaceList(tb_roomface model)
		{
			int count = 0;
			ViewBag.list = dtb_roomface.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 楼层展示图 保存
		/// </summary>
		public bool roomfaceSave(tb_roomface model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droomface.Update(model);
			}
			return droomface.Add(model)>0;
		}

		/// <summary>
		/// 楼层展示图 删除
		/// </summary>
		public bool roomfaceDelete(tb_roomface model)
		{
			return droomface.Delete(model);
		}

		/// <summary>
		/// 楼层展示图 详情
		/// </summary>
		public ActionResult roomfaceInfo(tb_roomface model)
		{
			ViewBag.Info = droomface.GetInfo(model);
			return View();
		}

	}
}

