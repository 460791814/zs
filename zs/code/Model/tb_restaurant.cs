using System;
namespace Model
{
	/// <summary>
	/// ������ʳ
	/// </summary>
	[Serializable]
	public partial class tb_restaurant:BaseModel
	{
		public tb_restaurant()
		{}
		#region Model
		private string _id;
		private int? _houseid;
		private string _name;
		private string _address;
		private string _hold;
		private string _phone;
		private string _dinnertime;
		private int? _isopen;
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
		/// ¥��
		/// </summary>
		public int? houseid
		{
			set{ _houseid=value;}
			get{return _houseid;}
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
		/// ����λ��
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
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
		/// ��ϵ�绰
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// �Ͳ�ʱ��
		/// </summary>
		public string dinnertime
		{
			set{ _dinnertime=value;}
			get{return _dinnertime;}
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

