using System;
namespace Model
{
	/// <summary>
	/// ���೵�ͳ�λ����
	/// </summary>
	[Serializable]
	public partial class tb_parkspace:BaseModel
	{
		public tb_parkspace()
		{}
		#region Model
		private string _id;
		private int? _parkid;
		private string _name;
		private int? _number;
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
		/// ͣ����ID
		/// </summary>
		public int? parkid
		{
			set{ _parkid=value;}
			get{return _parkid;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int? number
		{
			set{ _number=value;}
			get{return _number;}
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

