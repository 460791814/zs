using System;
namespace 
{
	/// <summary>
	/// ���������豸��ʩ
	/// </summary>
	public  class roomdeviceController:Controller
	{
		D_roomdevice droomdevice = new D_roomdevice();
		/// <summary>
		/// ���������豸��ʩ �б�
		/// </summary>
		public ActionResult roomdeviceList(tb_roomdevice model)
		{
			int count = 0;
			ViewBag.list = dtb_roomdevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ���������豸��ʩ ����
		/// </summary>
		public bool roomdeviceSave(tb_roomdevice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droomdevice.Update(model);
			}
			return droomdevice.Add(model)>0;
		}

		/// <summary>
		/// ���������豸��ʩ ɾ��
		/// </summary>
		public bool roomdeviceDelete(tb_roomdevice model)
		{
			return droomdevice.Delete(model);
		}

		/// <summary>
		/// ���������豸��ʩ ����
		/// </summary>
		public ActionResult roomdeviceInfo(tb_roomdevice model)
		{
			ViewBag.Info = droomdevice.GetInfo(model);
			return View();
		}

	}
}

