using System;
namespace 
{
	/// <summary>
	/// ���ݹ���
	/// </summary>
	public  class documentController:Controller
	{
		D_document ddocument = new D_document();
		/// <summary>
		/// ���ݹ��� �б�
		/// </summary>
		public ActionResult documentList(tb_document model)
		{
			int count = 0;
			ViewBag.list = dtb_document.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ���ݹ��� ����
		/// </summary>
		public bool documentSave(tb_document model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return ddocument.Update(model);
			}
			return ddocument.Add(model)>0;
		}

		/// <summary>
		/// ���ݹ��� ɾ��
		/// </summary>
		public bool documentDelete(tb_document model)
		{
			return ddocument.Delete(model);
		}

		/// <summary>
		/// ���ݹ��� ����
		/// </summary>
		public ActionResult documentInfo(tb_document model)
		{
			ViewBag.Info = ddocument.GetInfo(model);
			return View();
		}

	}
}

