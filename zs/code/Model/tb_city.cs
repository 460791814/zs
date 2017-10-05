using System;
namespace Model
{
	/// <summary>
	/// ÊÐ
	/// </summary>
	[Serializable]
	public partial class tb_city:BaseModel
	{
		public tb_city()
		{}
		#region Model
		private string _cityname;
		private string _id;
		/// <summary>
		/// ÊÐÃû³Æ
		/// </summary>
		public string cityname
		{
			set{ _cityname=value;}
			get{return _cityname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		#endregion Model

	}
}

