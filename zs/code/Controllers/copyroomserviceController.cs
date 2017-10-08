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
	/// �������
	/// </summary>
	public  class copyroomserviceController:Controller
	{
		D_copyroomservice dcopyroomservice = new D_copyroomservice();
		/// <summary>
		/// ������� �б�
		/// </summary>
		public ActionResult copyroomserviceList(tb_copyroomservice model)
		{
			int count = 0;
			ViewBag.list = dcopyroomservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������� ����
		/// </summary>
		public bool copyroomserviceSave(tb_copyroomservice model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dcopyroomservice.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dcopyroomservice.Add(model);
		}

		/// <summary>
		/// ������� ɾ��
		/// </summary>
		public bool copyroomserviceDelete(tb_copyroomservice model)
		{
			return dcopyroomservice.Delete(model);
		}

		/// <summary>
		/// ������� ����
		/// </summary>
		public ActionResult copyroomserviceInfo(tb_copyroomservice model)
		{
			model = dcopyroomservice.GetInfo(model);
			return View(model??new tb_copyroomservice());
		}

	}
}

