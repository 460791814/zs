using System;
namespace 
{
	/// <summary>
	/// ¥��
	/// </summary>
	public  class houseController:Controller
	{
		D_house dhouse = new D_house();
		/// <summary>
		/// ¥�� �б�
		/// </summary>
		public ActionResult houseList(tb_house model)
		{
			int count = 0;
			ViewBag.list = dtb_house.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ¥�� ����
		/// </summary>
		public bool houseSave(tb_house model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dhouse.Update(model);
			}
			return dhouse.Add(model)>0;
		}

		/// <summary>
		/// ¥�� ɾ��
		/// </summary>
		public bool houseDelete(tb_house model)
		{
			return dhouse.Delete(model);
		}

		/// <summary>
		/// ¥�� ����
		/// </summary>
		public ActionResult houseInfo(tb_house model)
		{
			ViewBag.Info = dhouse.GetInfo(model);
			return View();
		}

	}
}

