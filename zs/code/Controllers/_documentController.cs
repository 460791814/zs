using System;
namespace 
{
	/// <summary>
	/// ���ݹ���
	/// </summary>
	public  class _documentController:Controller
	{
		D_tb_document dtb_document = new D_tb_document();
		/// <summary>
		/// ���ݹ��� �б�
		/// </summary>
		public ActionResult   _documentList(tb_document model)		{
			int count = 0;
			ViewBag.list = dtb_document.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

	}
}

