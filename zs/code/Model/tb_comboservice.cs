using System;
namespace Model
{
	/// <summary>
	/// �ײͷ�������
	/// </summary>
	[Serializable]
	public partial class tb_comboservice:BaseModel
	{
		public tb_comboservice()
		{}
		#region Model
		private int? _comboid;
		private string _name;
		private string _intro;
		private string _id;
		private DateTime? _addtime;
		/// <summary>
		/// �ײ�ID
		/// </summary>
		public int? comboid
		{
			set{ _comboid=value;}
			get{return _comboid;}
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

