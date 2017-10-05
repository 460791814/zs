using System;
namespace 
{
	/// <summary>
	/// �ļ���
	/// </summary>
	public  class fileController:Controller
	{
		D_file dfile = new D_file();
		/// <summary>
		/// �ļ��� �б�
		/// </summary>
		public ActionResult fileList(tb_file model)
		{
			int count = 0;
			ViewBag.list = dtb_file.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �ļ��� ����
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
		/// �ļ��� ɾ��
		/// </summary>
		public bool fileDelete(tb_file model)
		{
			return dfile.Delete(model);
		}

		/// <summary>
		/// �ļ��� ����
		/// </summary>
		public ActionResult fileInfo(tb_file model)
		{
			ViewBag.Info = dfile.GetInfo(model);
			return View();
		}

	}
}

