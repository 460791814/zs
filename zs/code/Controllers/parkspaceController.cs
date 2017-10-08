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
	/// ���೵�ͳ�λ����
	/// </summary>
	public  class parkspaceController:Controller
	{
		D_parkspace dparkspace = new D_parkspace();
		/// <summary>
		/// ���೵�ͳ�λ���� �б�
		/// </summary>
		public ActionResult parkspaceList(tb_parkspace model)
		{
			int count = 0;
			ViewBag.list = dparkspace.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ���೵�ͳ�λ���� ����
		/// </summary>
		public bool parkspaceSave(tb_parkspace model)
		{
			if (model == null)
			{
				return false;
			}
			if(!String.IsNullOrEmpty(model.id))
			{
				 return dparkspace.Update(model);
			}
			model.id = Guid.NewGuid().ToString("N");
			return dparkspace.Add(model);
		}

		/// <summary>
		/// ���೵�ͳ�λ���� ɾ��
		/// </summary>
		public bool parkspaceDelete(tb_parkspace model)
		{
			return dparkspace.Delete(model);
		}

		/// <summary>
		/// ���೵�ͳ�λ���� ����
		/// </summary>
		public ActionResult parkspaceInfo(tb_parkspace model)
		{
			model = dparkspace.GetInfo(model);
			return View(model??new tb_parkspace());
		}

	}
}

