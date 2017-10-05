using System;
namespace 
{
	/// <summary>
	/// 文件表
	/// </summary>
	public  class fileController:Controller
	{
		D_file dfile = new D_file();
		/// <summary>
		/// 文件表 列表
		/// </summary>
		public ActionResult fileList(tb_file model)
		{
			int count = 0;
			ViewBag.list = dtb_file.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// 文件表 保存
		/// </summary>
		public bool fileSave(tb_file model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dfile.Update(model);
			}
			return dfile.Add(model)>0;
		}

		/// <summary>
		/// 文件表 删除
		/// </summary>
		public bool fileDelete(tb_file model)
		{
			return dfile.Delete(model);
		}

		/// <summary>
		/// 文件表 详情
		/// </summary>
		public ActionResult fileInfo(tb_file model)
		{
			ViewBag.Info = dfile.GetInfo(model);
			return View();
		}

	}
}

