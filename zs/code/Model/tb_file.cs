using System;
namespace Model
{
	/// <summary>
	/// �ļ���
	/// </summary>
	[Serializable]
	public partial class tb_file:BaseModel
	{
		public tb_file()
		{}
		#region Model
		private string _id;
		private int? _typeid;
		private int? _filetypeid;
		private int? _infoid;
		private string _name;
		private string _intro;
		private string _address;
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
		/// 1��¥����òչʾͼ��2��¥����ϸչʾͼ��3��¥��չʾͼ��4������չʾͼ��5��������չʾͼ��6������չʾͼ��7����ӡ��չʾͼ
		/// </summary>
		public int? typeid
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 1��ͼƬ��2��Word��3��PPT...
		/// </summary>
		public int? filetypeid
		{
			set{ _filetypeid=value;}
			get{return _filetypeid;}
		}
		/// <summary>
		/// ¥��ID��������ID����ӡID....
		/// </summary>
		public int? infoid
		{
			set{ _infoid=value;}
			get{return _infoid;}
		}
		/// <summary>
		/// �ļ�����
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// �ļ����
		/// </summary>
		public string intro
		{
			set{ _intro=value;}
			get{return _intro;}
		}
		/// <summary>
		/// �ļ���ַ
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
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

