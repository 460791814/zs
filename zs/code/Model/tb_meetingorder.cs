using System;
namespace Model
{
	/// <summary>
	/// ������� ����Ԥ������
	/// </summary>
	[Serializable]
	public partial class tb_meetingorder:BaseModel
	{
		public tb_meetingorder()
		{}
		#region Model
		private string _id;
		private string _orderno;
		private string _buildingid;
		private string _buildingname;
		private string _meetingroomid;
		private string _meetingroomname;
		private string _comboid;
		private string _comboname;
		private string _userid;
		private string _username;
		private string _userphone;
		private int? _meetingpersonnum;
		private DateTime? _meetingdate;
		private string _meetingamorpm;
		private string _status;
		private string _linkman;
		private string _linktel;
		private int? _meetingnum;
		private string _remark;
		private string _otherservice;
		private bool _isdel;
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
		/// �������
		/// </summary>
		public string orderno
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// ¥�����
		/// </summary>
		public string buildingid
		{
			set{ _buildingid=value;}
			get{return _buildingid;}
		}
		/// <summary>
		/// ¥������
		/// </summary>
		public string buildingname
		{
			set{ _buildingname=value;}
			get{return _buildingname;}
		}
		/// <summary>
		/// �����ұ����
		/// </summary>
		public string meetingroomid
		{
			set{ _meetingroomid=value;}
			get{return _meetingroomid;}
		}
		/// <summary>
		/// ����������
		/// </summary>
		public string meetingroomname
		{
			set{ _meetingroomname=value;}
			get{return _meetingroomname;}
		}
		/// <summary>
		/// �ײͱ����
		/// </summary>
		public string comboid
		{
			set{ _comboid=value;}
			get{return _comboid;}
		}
		/// <summary>
		/// �ײ�����
		/// </summary>
		public string comboname
		{
			set{ _comboname=value;}
			get{return _comboname;}
		}
		/// <summary>
		/// �µ��û�
		/// </summary>
		public string userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// �µ��û�����
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// �û���ϵ�绰
		/// </summary>
		public string userphone
		{
			set{ _userphone=value;}
			get{return _userphone;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public int? meetingpersonnum
		{
			set{ _meetingpersonnum=value;}
			get{return _meetingpersonnum;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime? meetingdate
		{
			set{ _meetingdate=value;}
			get{return _meetingdate;}
		}
		/// <summary>
		/// ���������
		/// </summary>
		public string meetingAMorPM
		{
			set{ _meetingamorpm=value;}
			get{return _meetingamorpm;}
		}
		/// <summary>
		/// ����״̬
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string linkman
		{
			set{ _linkman=value;}
			get{return _linkman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string linktel
		{
			set{ _linktel=value;}
			get{return _linktel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? meetingnum
		{
			set{ _meetingnum=value;}
			get{return _meetingnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string otherservice
		{
			set{ _otherservice=value;}
			get{return _otherservice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isdel
		{
			set{ _isdel=value;}
			get{return _isdel;}
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

