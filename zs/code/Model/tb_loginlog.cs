using System;
namespace Model
{
	/// <summary>
	/// ��½��־
	/// </summary>
	[Serializable]
	public partial class tb_loginlog:BaseModel
	{
		public tb_loginlog()
		{}
		#region Model
		private string _id;
		private string _username;
		private string _ip;
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
		/// �û���
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// ����IP
		/// </summary>
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// ��½ʱ��
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

