using System;
namespace Model
{
	/// <summary>
	/// �����������豸��ʩ
	/// </summary>
	[Serializable]
	public partial class tb_meetingroomdevice:BaseModel
	{
		public tb_meetingroomdevice()
		{}
		#region Model
		private string _id;
		private int? _meetingroomid;
		private string _name;
		private string _intro;
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
		/// ������ID
		/// </summary>
		public int? meetingroomid
		{
			set{ _meetingroomid=value;}
			get{return _meetingroomid;}
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
		/// ˵��
		/// </summary>
		public string intro
		{
			set{ _intro=value;}
			get{return _intro;}
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
