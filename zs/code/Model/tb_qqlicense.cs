using System;
namespace Model
{
	/// <summary>
	/// qq
	/// </summary>
	[Serializable]
	public partial class tb_qqlicense:BaseModel
	{
		public tb_qqlicense()
		{}
		#region Model
		private string _id;
		private string _openid;
		private DateTime? _addtime;
		private int? _subscribe;
		private string _nickname;
		private int? _sex;
		private string _city;
		private string _country;
		private string _province;
		private string _language;
		private string _headimgurl;
		private string _subscribe_time;
		private string _unionid;
		private string _code;
		private string _usertype;
		private string _userid;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ���ں�ID
		/// </summary>
		public string openid
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// ������Ϣ
		/// </summary>
		public int? subscribe
		{
			set{ _subscribe=value;}
			get{return _subscribe;}
		}
		/// <summary>
		/// �ǳ�
		/// </summary>
		public string nickname
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// �Ա�
		/// </summary>
		public int? sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string city
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string country
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// ʡ��
		/// </summary>
		public string province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string language
		{
			set{ _language=value;}
			get{return _language;}
		}
		/// <summary>
		/// ��ͷͼƬ��ַ
		/// </summary>
		public string headimgurl
		{
			set{ _headimgurl=value;}
			get{return _headimgurl;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public string subscribe_time
		{
			set{ _subscribe_time=value;}
			get{return _subscribe_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unionid
		{
			set{ _unionid=value;}
			get{return _unionid;}
		}
		/// <summary>
		/// ��Ŷ�Ӧ�ͻ������ά�������
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// �û����ͣ��ͻ���ά����
		/// </summary>
		public string userType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

