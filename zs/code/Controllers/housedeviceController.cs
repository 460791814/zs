using System;
namespace 
{
	/// <summary>
	/// ¥�������豸
	/// </summary>
	public  class housedeviceController:Controller
	{
		D_housedevice dhousedevice = new D_housedevice();
		/// <summary>
		/// ¥�������豸 �б�
		/// </summary>
		public ActionResult housedeviceList(tb_housedevice model)
		{
			int count = 0;
			ViewBag.list = dtb_housedevice.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ¥�������豸 ����
		/// </summary>
		public bool housedeviceSave(tb_housedevice model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dhousedevice.Update(model);
			}
			return dhousedevice.Add(model)>0;
		}

		/// <summary>
		/// ¥�������豸 ɾ��
		/// </summary>
		public bool housedeviceDelete(tb_housedevice model)
		{
			return dhousedevice.Delete(model);
		}

		/// <summary>
		/// ¥�������豸 ����
		/// </summary>
		public ActionResult housedeviceInfo(tb_housedevice model)
		{
			ViewBag.Info = dhousedevice.GetInfo(model);
			return View();
		}

	}
}

