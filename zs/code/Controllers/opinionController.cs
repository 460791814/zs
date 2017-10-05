using System;
namespace 
{
	/// <summary>
	/// �������
	/// </summary>
	public  class opinionController:Controller
	{
		D_opinion dopinion = new D_opinion();
		/// <summary>
		/// ������� �б�
		/// </summary>
		public ActionResult opinionList(tb_opinion model)
		{
			int count = 0;
			ViewBag.list = dtb_opinion.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ������� ����
		/// </summary>
		public bool opinionSave(tb_opinion model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dopinion.Update(model);
			}
			return dopinion.Add(model)>0;
		}

		/// <summary>
		/// ������� ɾ��
		/// </summary>
		public bool opinionDelete(tb_opinion model)
		{
			return dopinion.Delete(model);
		}

		/// <summary>
		/// ������� ����
		/// </summary>
		public ActionResult opinionInfo(tb_opinion model)
		{
			ViewBag.Info = dopinion.GetInfo(model);
			return View();
		}

	}
}

