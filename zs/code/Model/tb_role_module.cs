using System;
namespace Model
{
	/// <summary>
	/// Ȩ��ģ���ϵ��
	/// </summary>
	[Serializable]
	public partial class tb_role_module:BaseModel
	{
		public tb_role_module()
		{}
		#region Model
		private int _roleid;
		private int _moduleid;
		/// <summary>
		/// ���id
		/// </summary>
		public int roleid
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// ģ��id
		/// </summary>
		public int moduleid
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		#endregion Model

	}
}

