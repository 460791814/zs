using System;
namespace Model
{
	/// <summary>
	/// ��λ��Ϣ
	/// </summary>
	[Serializable]
	public partial class tb_park:BaseModel
	{
		public tb_park()
		{}
		#region Model
		private string _id;
		private int? _houseid;
		private string _parkname;
		private string _address;
		private int? _parknumber;
		private string _fee;
		private int? _isopen;
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
		/// ¥��
		/// </summary>
		public int? houseid
		{
			set{ _houseid=value;}
			get{return _houseid;}
		}
		/// <summary>
		/// ͣ��������
		/// </summary>
		public string parkname
		{
			set{ _parkname=value;}
			get{return _parkname;}
		}
		/// <summary>
		/// ͣ����λ��
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// �ܳ�λ����
		/// </summary>
		public int? parknumber
		{
			set{ _parknumber=value;}
			get{return _parknumber;}
		}
		/// <summary>
		/// �շѱ�׼
		/// </summary>
		public string fee
		{
			set{ _fee=value;}
			get{return _fee;}
		}
		/// <summary>
		/// �Ƿ񿪷�
		/// </summary>
		public int? isopen
		{
			set{ _isopen=value;}
			get{return _isopen;}
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

