using System;
namespace Model
{
	/// <summary>
	/// �ͻ���
	/// </summary>
	[Serializable]
	public partial class tb_user:BaseModel
	{
		public tb_user()
		{}
		#region Model
		private string _id;
		private string _code;
		private string _nickname;
		private string _phonenum;
		private string _address;
		private decimal? _longitude;
		private decimal? _latitude;
		private string _remark;
		private DateTime? _createdate;
		private DateTime? _updatedate;
		private string _pwd;
		private string _province;
		private string _city;
		private string _county;
		private string _location;
		private string _sex;
		private string _job;
		private int? _age;
		private string _constellation;
		private string _hav;
		private int? _tall;
		private string _schedule;
		private string _sgin;
		private string _hobby;
		private DateTime? _birth;
		private string _wx;
		private string _issingle;
		private string _company;
		private string _companyaddress;
		private string _realname;
		private string _avatar;
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
		/// Ψһ����
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// ��ϵ������
		/// </summary>
		public string nickname
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// ��ϵ���루��½�˺ţ�
		/// </summary>
		public string phonenum
		{
			set{ _phonenum=value;}
			get{return _phonenum;}
		}
		/// <summary>
		/// ��ַ
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public decimal? longitude
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// γ��
		/// </summary>
		public decimal? latitude
		{
			set{ _latitude=value;}
			get{return _latitude;}
		}
		/// <summary>
		/// ��ע
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime? createdate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime? updatedate
		{
			set{ _updatedate=value;}
			get{return _updatedate;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
		}
		/// <summary>
		/// ʡ
		/// </summary>
		public string province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// ��
		/// </summary>
		public string city
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// ��
		/// </summary>
		public string county
		{
			set{ _county=value;}
			get{return _county;}
		}
		/// <summary>
		/// ���ڵ�
		/// </summary>
		public string location
		{
			set{ _location=value;}
			get{return _location;}
		}
		/// <summary>
		/// �Ա�
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// ְҵ
		/// </summary>
		public string job
		{
			set{ _job=value;}
			get{return _job;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int? age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string constellation
		{
			set{ _constellation=value;}
			get{return _constellation;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string hav
		{
			set{ _hav=value;}
			get{return _hav;}
		}
		/// <summary>
		/// ���
		/// </summary>
		public int? tall
		{
			set{ _tall=value;}
			get{return _tall;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string schedule
		{
			set{ _schedule=value;}
			get{return _schedule;}
		}
		/// <summary>
		/// ����ǩ��
		/// </summary>
		public string sgin
		{
			set{ _sgin=value;}
			get{return _sgin;}
		}
		/// <summary>
		/// ��Ȥ����
		/// </summary>
		public string hobby
		{
			set{ _hobby=value;}
			get{return _hobby;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public DateTime? birth
		{
			set{ _birth=value;}
			get{return _birth;}
		}
		/// <summary>
		/// ΢�ź�
		/// </summary>
		public string wx
		{
			set{ _wx=value;}
			get{return _wx;}
		}
		/// <summary>
		/// �Ƿ���
		/// </summary>
		public string issingle
		{
			set{ _issingle=value;}
			get{return _issingle;}
		}
		/// <summary>
		/// ���ڵ�λ
		/// </summary>
		public string company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// ��λ��ַ
		/// </summary>
		public string companyaddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
		}
		/// <summary>
		/// ��ʵ����
		/// </summary>
		public string realname
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string avatar
		{
			set{ _avatar=value;}
			get{return _avatar;}
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

