using System;
namespace Model
{
	/// <summary>
	/// ��
	/// </summary>
	[Serializable]
	public partial class tb_county:BaseModel
	{
		public tb_county()
		{}
		#region Model
		private string _id;
		private string _countyname;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string countyname
		{
			set{ _countyname=value;}
			get{return _countyname;}
		}
		#endregion Model

	}
}

