using System;
namespace Model
{
	/// <summary>
	/// ��ӡ���
	/// </summary>
	[Serializable]
	public partial class tb_copyroom:BaseModel
	{
		public tb_copyroom()
		{}
		#region Model
		private int? _houseid;
		private string _name;
		private string _address;
		private string _phone;
		private int? _isopen;
		private string _intro;
		private string _id;
		private DateTime? _addtime;
		/// <summary>
		/// ¥��
		/// </summary>
		public int? houseid
		{
			set{ _houseid=value;}
			get{return _houseid;}
		}
		/// <summary>
		/// ��ӡ������
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ��ӡ��λ��
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
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
		/// �Ƿ񿪷�
		/// </summary>
		public int? isopen
		{
			set{ _isopen=value;}
			get{return _isopen;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public string intro
		{
			set{ _intro=value;}
			get{return _intro;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
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

