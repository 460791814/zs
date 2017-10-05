using System;
namespace 
{
	/// <summary>
	/// �����������豸��ʩ
	/// </summary>
	public  class meetingroomdeviceController:Controller
	{
		D_meetingroomdevice dmeetingroomdevice = new D_meetingroomdevice();
		/// <summary>
		/// �����������豸��ʩ �б�
		/// </summary>
		public ActionResult meetingroomdeviceList(tb_meetingroomdevice model)
		{
			int count = 0;
			ViewBag.list = dtb_meetingroomdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// �����������豸��ʩ ����
		/// </summary>
		public bool meetingroomdeviceSave(tb_meetingroomdevice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dmeetingroomdevice.Update(model);
			}
			return dmeetingroomdevice.Add(model)>0;
		}

		/// <summary>
		/// �����������豸��ʩ ɾ��
		/// </summary>
		public bool meetingroomdeviceDelete(tb_meetingroomdevice model)
		{
			return dmeetingroomdevice.Delete(model);
		}

		/// <summary>
		/// �����������豸��ʩ ����
		/// </summary>
		public ActionResult meetingroomdeviceInfo(tb_meetingroomdevice model)
		{
			ViewBag.Info = dmeetingroomdevice.GetInfo(model);
			return View();
		}

	}
}

