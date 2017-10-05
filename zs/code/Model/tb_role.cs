using System;
namespace Model
{
	/// <summary>
	/// ½ÇÉ«
	/// </summary>
	[Serializable]
	public partial class tb_role:BaseModel
	{
		public tb_role()
		{}
		#region Model
		private string _id;
		private string _name;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ½ÇÉ«Ãû³Æ
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model

	}
}

