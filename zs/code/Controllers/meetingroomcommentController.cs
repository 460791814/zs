using System;
namespace 
{
	/// <summary>
	/// ����������
	/// </summary>
	public  class meetingroomcommentController:Controller
	{
		D_meetingroomcomment dmeetingroomcomment = new D_meetingroomcomment();
		/// <summary>
		/// ���������� �б�
		/// </summary>
		public ActionResult meetingroomcommentList(tb_meetingroomcomment model)
		{
			int count = 0;
			ViewBag.list = dtb_meetingroomcomment.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ���������� ����
		/// </summary>
		public bool meetingroomcommentSave(tb_meetingroomcomment model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dmeetingroomcomment.Update(model);
			}
			return dmeetingroomcomment.Add(model)>0;
		}

		/// <summary>
		/// ���������� ɾ��
		/// </summary>
		public bool meetingroomcommentDelete(tb_meetingroomcomment model)
		{
			return dmeetingroomcomment.Delete(model);
		}

		/// <summary>
		/// ���������� ����
		/// </summary>
		public ActionResult meetingroomcommentInfo(tb_meetingroomcomment model)
		{
			ViewBag.Info = dmeetingroomcomment.GetInfo(model);
			return View();
		}

	}
}

