using System;
namespace Model
{
	/// <summary>
	/// �շѱ�׼
	/// </summary>
	[Serializable]
	public partial class tb_copyroomfee:BaseModel
	{
		public tb_copyroomfee()
		{}
		#region Model
		private string _id;
		private int? _copyroomid;
		private string _name;
		private string _intro;
		private string _fee;
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
		/// ��ӡ��id
		/// </summary>
		public int? copyroomid
		{
			set{ _copyroomid=value;}
			get{return _copyroomid;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string intro
		{
			set{ _intro=value;}
			get{return _intro;}
		}
		/// <summary>
		/// �۸�
		/// </summary>
		public string fee
		{
			set{ _fee=value;}
			get{return _fee;}
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

