using System;
namespace Model
{
	/// <summary>
	/// ÖÜ±ßÅäÌ×½éÉÜ
	/// </summary>
	[Serializable]
	public partial class tb_housearound:BaseModel
	{
		public tb_housearound()
		{}
		#region Model
		private string _id;
		private int? _houseid;
		private string _name;
		private string _intro;
		private DateTime? _addtime;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// Â¥Óî
		/// </summary>
		public int? houseid
		{
			set{ _houseid=value;}
			get{return _houseid;}
		}
		/// <summary>
		/// ÖÜ±ß½éÉÜ
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ËµÃ÷
		/// </summary>
		public string intro
		{
			set{ _intro=value;}
			get{return _intro;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

