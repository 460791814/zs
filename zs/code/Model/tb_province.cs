using System;
namespace Model
{
	/// <summary>
	/// Ê¡
	/// </summary>
	[Serializable]
	public partial class tb_province:BaseModel
	{
		public tb_province()
		{}
		#region Model
		private string _id;
		private string _provincename;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// Ê¡Ãû³Æ
		/// </summary>
		public string provincename
		{
			set{ _provincename=value;}
			get{return _provincename;}
		}
		#endregion Model

	}
}

