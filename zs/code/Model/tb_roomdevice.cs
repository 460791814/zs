using System;
namespace Model
{
	/// <summary>
	/// ���������豸��ʩ
	/// </summary>
	[Serializable]
	public partial class tb_roomdevice:BaseModel
	{
		public tb_roomdevice()
		{}
		#region Model
		private string _id;
		private int? _roomid;
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
		/// ����ID
		/// </summary>
		public int? roomid
		{
			set{ _roomid=value;}
			get{return _roomid;}
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
		/// ˵��
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

