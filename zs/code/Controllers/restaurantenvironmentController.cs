using System;
namespace 
{
	/// <summary>
	/// ������������
	/// </summary>
	public  class restaurantenvironmentController:Controller
	{
		D_restaurantenvironment drestaurantenvironment = new D_restaurantenvironment();
		/// <summary>
		/// ������������ �б�
		/// </summary>
		public ActionResult restaurantenvironmentList(tb_restaurantenvironment model)
		{
			int count = 0;
			ViewBag.list = dtb_restaurantenvironment.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������������ ����
		/// </summary>
		public bool restaurantenvironmentSave(tb_restaurantenvironment model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return drestaurantenvironment.Update(model);
			}
			return drestaurantenvironment.Add(model)>0;
		}

		/// <summary>
		/// ������������ ɾ��
		/// </summary>
		public bool restaurantenvironmentDelete(tb_restaurantenvironment model)
		{
			return drestaurantenvironment.Delete(model);
		}

		/// <summary>
		/// ������������ ����
		/// </summary>
		public ActionResult restaurantenvironmentInfo(tb_restaurantenvironment model)
		{
			ViewBag.Info = drestaurantenvironment.GetInfo(model);
			return View();
		}

	}
}

