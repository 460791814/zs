using System;
namespace Model
{
	/// <summary>
	/// 权限模块关系表
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
		/// 身份id
		/// </summary>
		public int roleid
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 模块id
		/// </summary>
		public int moduleid
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		#endregion Model

	}
}

