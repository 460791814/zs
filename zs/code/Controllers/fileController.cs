using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Model;
using Comp;
namespace cnooc.property.manage.Controllers
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
			ViewBag.list = dfile.GetList(model, ref count);
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
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dfile.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dfile.Add(model);
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
			model = dfile.GetInfo(model);
			return View(model??new tb_file());
		}

	}
}

