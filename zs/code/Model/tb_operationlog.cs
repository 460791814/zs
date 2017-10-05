using System;
namespace Model
{
	/// <summary>
	/// ������־
	/// </summary>
	[Serializable]
	public partial class tb_operationlog:BaseModel
	{
		public tb_operationlog()
		{}
		#region Model
		private string _id;
		private string _username;
		private string _ip;
		private string _target;
		private string _action;
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
		/// ��������
		/// </summary>
		public string target
		{
			set{ _target=value;}
			get{return _target;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string action
		{
			set{ _action=value;}
			get{return _action;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

