using System;
namespace 
{
	/// <summary>
	/// ¥��չʾͼ
	/// </summary>
	public  class roomfaceController:Controller
	{
		D_roomface droomface = new D_roomface();
		/// <summary>
		/// ¥��չʾͼ �б�
		/// </summary>
		public ActionResult roomfaceList(tb_roomface model)
		{
			int count = 0;
			ViewBag.list = dtb_roomface.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ¥��չʾͼ ����
		/// </summary>
		public bool roomfaceSave(tb_roomface model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return droomface.Update(model);
			}
			return droomface.Add(model)>0;
		}

		/// <summary>
		/// ¥��չʾͼ ɾ��
		/// </summary>
		public bool roomfaceDelete(tb_roomface model)
		{
			return droomface.Delete(model);
		}

		/// <summary>
		/// ¥��չʾͼ ����
		/// </summary>
		public ActionResult roomfaceInfo(tb_roomface model)
		{
			ViewBag.Info = droomface.GetInfo(model);
			return View();
		}

	}
}

