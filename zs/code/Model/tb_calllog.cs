using System;
namespace Model
{
	/// <summary>
	/// ���м�¼
	/// </summary>
	[Serializable]
	public partial class tb_calllog:BaseModel
	{
		public tb_calllog()
		{}
		#region Model
		private string _phone;
		private string _calltype;
		private DateTime? _addtime;
		private string _id;
		/// <summary>
		/// ��ϵ�绰
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// ��ѯ����
		/// </summary>
		public string calltype
		{
			set{ _calltype=value;}
			get{return _calltype;}
		}
		/// <summary>
		/// ��ѯʱ��
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		#endregion Model

	}
}

