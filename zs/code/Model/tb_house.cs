using System;
namespace Model
{
	/// <summary>
	/// ¥��
	/// </summary>
	[Serializable]
	public partial class tb_house:BaseModel
	{
		public tb_house()
		{}
		#region Model
		private string _id;
		private string _housename;
		private string _administrative;
		private string _provinceid;
		private string _cityid;
		private string _countyid;
		private string _address;
		private string _propertycompany;
		private string _propertycompanyintro;
		private string _traffic;
		private string _customer;
		private decimal? _longitude=nullM;
		private decimal? _latitude=nullM;
		private bool _isdel;
		private int? _sortnum;
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
		/// ¥������
		/// </summary>
		public string housename
		{
			set{ _housename=value;}
			get{return _housename;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string administrative
		{
			set{ _administrative=value;}
			get{return _administrative;}
		}
		/// <summary>
		/// ʡ
		/// </summary>
		public string provinceid
		{
			set{ _provinceid=value;}
			get{return _provinceid;}
		}
		/// <summary>
		/// ��
		/// </summary>
		public string cityid
		{
			set{ _cityid=value;}
			get{return _cityid;}
		}
		/// <summary>
		/// ��
		/// </summary>
		public string countyid
		{
			set{ _countyid=value;}
			get{return _countyid;}
		}
		/// <summary>
		/// ��ϸ��ַ
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// ��ҵ��˾
		/// </summary>
		public string propertycompany
		{
			set{ _propertycompany=value;}
			get{return _propertycompany;}
		}
		/// <summary>
		/// ��ҵ��˾���
		/// </summary>
		public string propertycompanyintro
		{
			set{ _propertycompanyintro=value;}
			get{return _propertycompanyintro;}
		}
		/// <summary>
		/// ��ͨ��Ϣ
		/// </summary>
		public string traffic
		{
			set{ _traffic=value;}
			get{return _traffic;}
		}
		/// <summary>
		/// �ͷ��绰
		/// </summary>
		public string customer
		{
			set{ _customer=value;}
			get{return _customer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? longitude
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? latitude
		{
			set{ _latitude=value;}
			get{return _latitude;}
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
		public int? sortnum
		{
			set{ _sortnum=value;}
			get{return _sortnum;}
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

