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
	/// �ͻ���
	/// </summary>
	public  class userController:Controller
	{
		D_user duser = new D_user();
		/// <summary>
		/// �ͻ��� �б�
		/// </summary>
		public ActionResult userList(tb_user model)
		{
			int count = 0;
			ViewBag.list = duser.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �ͻ��� ����
		/// </summary>
		public bool userSave(tb_user model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return duser.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return duser.Add(model);
		}

		/// <summary>
		/// �ͻ��� ɾ��
		/// </summary>
		public bool userDelete(tb_user model)
		{
			return duser.Delete(model);
		}

		/// <summary>
		/// �ͻ��� ����
		/// </summary>
		public ActionResult userInfo(tb_user model)
		{
			model = duser.GetInfo(model);
			return View(model??new tb_user());
		}

	}
}

