using System;
namespace 
{
	/// <summary>
	/// 文件表
	/// </summary>
	public  class _fileController:Controller
	{
		D_tb_file dtb_file = new D_tb_file();
		/// <summary>
		/// 文件表 列表
		/// </summary>
		public ActionResult   _fileList(tb_file model)		{
			int count = 0;
			ViewBag.list = dtb_file.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

