using System;
namespace Model
{
	/// <summary>
	/// Ȩ��ģ��
	/// </summary>
	[Serializable]
	public partial class tb_module:BaseModel
	{
		public tb_module()
		{}
		#region Model
		private string _id;
		private string _name;
		private string _url;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ģ������
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// ҳ���ַ
		/// </summary>
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		#endregion Model

	}
}

