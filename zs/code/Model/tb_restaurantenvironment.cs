using System;
namespace Model
{
	/// <summary>
	/// ������������
	/// </summary>
	[Serializable]
	public partial class tb_restaurantenvironment:BaseModel
	{
		public tb_restaurantenvironment()
		{}
		#region Model
		private string _id;
		private int? _restaurantid;
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
		/// ����id
		/// </summary>
		public int? restaurantid
		{
			set{ _restaurantid=value;}
			get{return _restaurantid;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ����
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

