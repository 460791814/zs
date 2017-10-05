﻿using CodeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BuilderController
{
   public  class BuilderMvcController
    {
        protected string _tabledescription = "";
        private string _namespace; //顶级命名空间名
        protected string _actionName = "";  
        
        protected List<ColumnInfo> _fieldlist;
        /// <summary>
        /// 顶级命名空间名 
        /// </summary>        
        public string NameSpace
        {
            set { _namespace = value; }
            get { return _namespace; }
        }
        /// <summary>
        ///Action类名
        /// </summary>
        public string ActionName
        {
            set { _actionName = value; }
            get { return _actionName; }
        }
        /// <summary>
        /// 表的描述信息
        /// </summary>
        public string TableDescription
        {
            set { _tabledescription = value; }
            get { return _tabledescription; }
        }
        /// <summary>
        /// 选择的字段集合
        /// </summary>
        public List<ColumnInfo> Fieldlist
        {
            set { _fieldlist = value; }
            get { return _fieldlist; }
        }
        /// <summary>
        /// 父类
        /// </summary>
        public string BaseClass { get; set; }
        public string ModelName { get; set; }
        #region 生成完整Model类
        /// <summary>
        /// 生成完整Model类
        /// </summary>		
        public string CreatController()
        {
            StringPlus stringPlus = new StringPlus();
            stringPlus.AppendLine("using System;");
            stringPlus.AppendLine("namespace " + _namespace);
            stringPlus.AppendLine("{");
            stringPlus.AppendSpaceLine(1, "/// <summary>");
            if (TableDescription.Length > 0)
            {
                stringPlus.AppendSpaceLine(1, "/// " + TableDescription.Replace("\r\n", "\r\n\t///"));
            }
            else
            {
                stringPlus.AppendSpaceLine(1, "/// " + _actionName);
            }
            stringPlus.AppendSpaceLine(1, "/// </summary>");
 
            stringPlus.AppendSpace(1, "public  class " + _actionName + "Controller");
            if (!string.IsNullOrEmpty(BaseClass))
            {
                stringPlus.Append(":" + BaseClass);
            }
            stringPlus.AppendLine("");
            stringPlus.AppendSpaceLine(1, "{");
            stringPlus.AppendSpaceLine(2, "D_"+ _actionName + " d" + _actionName + " = new D_" + _actionName + "();");

            stringPlus.AppendLine(CreateList());
            stringPlus.AppendLine(CreateSave());
            stringPlus.AppendLine(CreateDelete());
            stringPlus.AppendLine(CreateInfo());
            stringPlus.AppendSpaceLine(1, "}");
            stringPlus.AppendLine("}");
            stringPlus.AppendLine("");

            return stringPlus.ToString();

        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public string CreateList() {
            StringPlus stringPlus = new StringPlus();
            stringPlus.AppendSpaceLine(2, "/// <summary>");
            if (TableDescription.Length > 0)
            {
                stringPlus.AppendSpaceLine(2, "/// " + TableDescription.Replace("\r\n", "\r\n\t///")+" 列表");
            }
            else
            {
                stringPlus.AppendSpaceLine(2, "/// " + _actionName+ " 保存");
            }
            stringPlus.AppendSpaceLine(2, "/// </summary>");

            stringPlus.AppendSpaceLine(2, "public ActionResult "+ _actionName + "List(" + ModelName + " model)");
            stringPlus.AppendSpaceLine(2, "{");
            stringPlus.AppendSpaceLine(3, "int count = 0;");
            stringPlus.AppendSpaceLine(3, "ViewBag.list = d" + ModelName + ".GetList(model, ref count);");
            stringPlus.AppendSpaceLine(3, "ViewBag.page = Utils.ShowPage(count, model.PageSize, model.PageIndex, 5);");
            stringPlus.AppendSpaceLine(3, "return View();");
            stringPlus.AppendSpaceLine(2, "}");
            return stringPlus.ToString();
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public string CreateSave()
        {
            StringPlus stringPlus = new StringPlus();
            stringPlus.AppendSpaceLine(2, "/// <summary>");
            if (TableDescription.Length > 0)
            {
                stringPlus.AppendSpaceLine(2, "/// " + TableDescription.Replace("\r\n", "\r\n\t///") + " 保存");
            }
            else
            {
                stringPlus.AppendSpaceLine(2, "/// " + _actionName+ " 保存");
            }
            stringPlus.AppendSpaceLine(2, "/// </summary>");

            stringPlus.AppendSpaceLine(2, "public bool " + _actionName + "Save(" + ModelName + " model)");
            stringPlus.AppendSpaceLine(2, "{");
            stringPlus.AppendSpaceLine(3, "if (model == null)");
            stringPlus.AppendSpaceLine(3, "{");
            stringPlus.AppendSpaceLine(4, "return false");
            stringPlus.AppendSpaceLine(3, "}");

            stringPlus.AppendSpaceLine(3, "if (model."+Fieldlist.Find(a=>a.IsPrimaryKey)?.ColumnName+" >0)");
            stringPlus.AppendSpaceLine(3, "{");
            stringPlus.AppendSpaceLine(4, " return d"+ _actionName + ".Update(model);");
            stringPlus.AppendSpaceLine(3, "}");
            stringPlus.AppendSpaceLine(3, "return d"+ _actionName + ".Add(model)>0;");
            stringPlus.AppendSpaceLine(2, "}");
            return stringPlus.ToString();
        }
        /// <summary>
        /// 详情
        /// </summary>
        /// <returns></returns>
        public string CreateInfo()
        {
            StringPlus stringPlus = new StringPlus();
            stringPlus.AppendSpaceLine(2, "/// <summary>");
            if (TableDescription.Length > 0)
            {
                stringPlus.AppendSpaceLine(2, "/// " + TableDescription.Replace("\r\n", "\r\n\t///") + " 详情");
            }
            else
            {
                stringPlus.AppendSpaceLine(2, "/// " + _actionName + " 详情");
            }
            stringPlus.AppendSpaceLine(2, "/// </summary>");

            stringPlus.AppendSpaceLine(2, "public ActionResult " + _actionName + "Info(" + ModelName + " model)");
            stringPlus.AppendSpaceLine(2, "{");
            stringPlus.AppendSpaceLine(3, "ViewBag.Info = d" + _actionName + ".GetInfo(model);");
            stringPlus.AppendSpaceLine(3, "return View();");
          
            stringPlus.AppendSpaceLine(2, "}");
            return stringPlus.ToString();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public string CreateDelete()
        {
            StringPlus stringPlus = new StringPlus();
            stringPlus.AppendSpaceLine(2, "/// <summary>");
            if (TableDescription.Length > 0)
            {
                stringPlus.AppendSpaceLine(2, "/// " + TableDescription.Replace("\r\n", "\r\n\t///") + " 删除");
            }
            else
            {
                stringPlus.AppendSpaceLine(2, "/// " + _actionName + " 删除");
            }
            stringPlus.AppendSpaceLine(2, "/// </summary>");

            stringPlus.AppendSpaceLine(2, "public bool " + _actionName + "Delete(" + ModelName + " model)");
            stringPlus.AppendSpaceLine(2, "{");
            stringPlus.AppendSpaceLine(3, "return d"+ _actionName + ".Delete(model);");
          

            stringPlus.AppendSpaceLine(2, "}");
            return stringPlus.ToString();
        }
        #endregion
    }
}
