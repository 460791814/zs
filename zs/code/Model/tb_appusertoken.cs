using System;
namespace Model
{
	/// <summary>
	/// App�û���½Token
	/// </summary>
	[Serializable]
	public partial class tb_appusertoken:BaseModel
	{
		public tb_appusertoken()
		{}
		#region Model
		private string _id;
		private string _usertype;
		private string _code;
		private DateTime? _addtime;
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
		/// customer����serviceUser
		/// </summary>
		public string usertype
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// ���ɵļ����ַ���
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// �û���ά�������id
		/// </summary>
		public string userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

