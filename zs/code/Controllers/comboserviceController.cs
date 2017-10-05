using System;
namespace 
{
	/// <summary>
	/// �ײͷ�������
	/// </summary>
	public  class comboserviceController:Controller
	{
		D_comboservice dcomboservice = new D_comboservice();
		/// <summary>
		/// �ײͷ������� �б�
		/// </summary>
		public ActionResult comboserviceList(tb_comboservice model)
		{
			int count = 0;
			ViewBag.list = dtb_comboservice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �ײͷ������� ����
		/// </summary>
		public bool comboserviceSave(tb_comboservice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dcomboservice.Update(model);
			}
			return dcomboservice.Add(model)>0;
		}

		/// <summary>
		/// �ײͷ������� ɾ��
		/// </summary>
		public bool comboserviceDelete(tb_comboservice model)
		{
			return dcomboservice.Delete(model);
		}

		/// <summary>
		/// �ײͷ������� ����
		/// </summary>
		public ActionResult comboserviceInfo(tb_comboservice model)
		{
			ViewBag.Info = dcomboservice.GetInfo(model);
			return View();
		}

	}
}

