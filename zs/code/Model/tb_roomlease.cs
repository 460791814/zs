using System;
namespace Model
{
	/// <summary>
	/// �������
	/// </summary>
	[Serializable]
	public partial class tb_roomlease:BaseModel
	{
		public tb_roomlease()
		{}
		#region Model
		private string _id;
		private int? _roomid;
		private string _company;
		private string _time;
		private string _linkman;
		private string _phone;
		private string _emergencylinkman;
		private string _emergencyphone;
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
		/// �������
		/// </summary>
		public string company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// ��ϵ��
		/// </summary>
		public string linkman
		{
			set{ _linkman=value;}
			get{return _linkman;}
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
		/// ������ϵ��
		/// </summary>
		public string emergencylinkman
		{
			set{ _emergencylinkman=value;}
			get{return _emergencylinkman;}
		}
		/// <summary>
		/// ������ϵ�绰
		/// </summary>
		public string emergencyphone
		{
			set{ _emergencyphone=value;}
			get{return _emergencyphone;}
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

