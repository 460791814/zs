using System;
namespace 
{
	/// <summary>
	/// ��ҳ �Ƽ�����
	/// </summary>
	public  class featureController:Controller
	{
		D_feature dfeature = new D_feature();
		/// <summary>
		/// ��ҳ �Ƽ����� �б�
		/// </summary>
		public ActionResult featureList(tb_feature model)
		{
			int count = 0;
			ViewBag.list = dtb_feature.GetList(model, ref count);
			ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);
			return View();
		}

		/// <summary>
		/// ��ҳ �Ƽ����� ����
		/// </summary>
		public bool featureSave(tb_feature model)
		{
			if (model == null)
			{
				return false
			}
			if (model.id >0)
			{
				 return dfeature.Update(model);
			}
			return dfeature.Add(model)>0;
		}

		/// <summary>
		/// ��ҳ �Ƽ����� ɾ��
		/// </summary>
		public bool featureDelete(tb_feature model)
		{
			return dfeature.Delete(model);
		}

		/// <summary>
		/// ��ҳ �Ƽ����� ����
		/// </summary>
		public ActionResult featureInfo(tb_feature model)
		{
			ViewBag.Info = dfeature.GetInfo(model);
			return View();
		}

	}
}

