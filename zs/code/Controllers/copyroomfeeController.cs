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
	/// �շѱ�׼
	/// </summary>
	public  class copyroomfeeController:Controller
	{
		D_copyroomfee dcopyroomfee = new D_copyroomfee();
		/// <summary>
		/// �շѱ�׼ �б�
		/// </summary>
		public ActionResult copyroomfeeList(tb_copyroomfee model)
		{
			int count = 0;
			ViewBag.list = dcopyroomfee.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �շѱ�׼ ����
		/// </summary>
		public bool copyroomfeeSave(tb_copyroomfee model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dcopyroomfee.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dcopyroomfee.Add(model);
		}

		/// <summary>
		/// �շѱ�׼ ɾ��
		/// </summary>
		public bool copyroomfeeDelete(tb_copyroomfee model)
		{
			return dcopyroomfee.Delete(model);
		}

		/// <summary>
		/// �շѱ�׼ ����
		/// </summary>
		public ActionResult copyroomfeeInfo(tb_copyroomfee model)
		{
			model = dcopyroomfee.GetInfo(model);
			return View(model??new tb_copyroomfee());
		}

	}
}

