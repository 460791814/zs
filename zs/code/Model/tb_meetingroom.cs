using System;
namespace Model
{
	/// <summary>
	/// �����ҹ���
	/// </summary>
	[Serializable]
	public partial class tb_meetingroom:BaseModel
	{
		public tb_meetingroom()
		{}
		#region Model
		private int _id;
		private int? _houseid;
		private string _intro;
		private string _phone;
		private string _floor;
		private string _roomnumber;
		private int? _desktype;
		private string _hold;
		private string _fee;
		private int? _isopen;
		private int? _roomtype;
		private string _package;
		private DateTime? _addtime;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ¥��
		/// </summary>
		public int? houseid
		{
			set{ _houseid=value;}
			get{return _houseid;}
		}
		/// <summary>
		/// ����������
		/// </summary>
		public string intro
		{
			set{ _intro=value;}
			get{return _intro;}
		}
		/// <summary>
		/// �ͷ��绰
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// ¥��
		/// </summary>
		public string floor
		{
			set{ _floor=value;}
			get{return _floor;}
		}
		/// <summary>
		/// �����
		/// </summary>
		public string roomnumber
		{
			set{ _roomnumber=value;}
			get{return _roomnumber;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int? desktype
		{
			set{ _desktype=value;}
			get{return _desktype;}
		}
		/// <summary>
		/// ����������
		/// </summary>
		public string hold
		{
			set{ _hold=value;}
			get{return _hold;}
		}
		/// <summary>
		/// �շѱ�׼
		/// </summary>
		public string fee
		{
			set{ _fee=value;}
			get{return _fee;}
		}
		/// <summary>
		/// �Ƿ񿪷�
		/// </summary>
		public int? isopen
		{
			set{ _isopen=value;}
			get{return _isopen;}
		}
		/// <summary>
		/// ����������
		/// </summary>
		public int? roomtype
		{
			set{ _roomtype=value;}
			get{return _roomtype;}
		}
		/// <summary>
		/// �������ײ�
		/// </summary>
		public string package
		{
			set{ _package=value;}
			get{return _package;}
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

