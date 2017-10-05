

using CodeHelper;
using DbObjects.SQL2012;
using IBuilder;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuilderModel;
using Utility;
using Comp;
using BuilderDALSQL;
using BuilderController;

namespace zs.Controllers
{
    public class ZSController : Controller
    {
        static string connStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        DbObject db = new DbObject(connStr);
        IBuilderModel builderModel = null;
        IBuilderDAL builderDAL = null;
        string dbName = "ryxz";
        // GET: ZS
        public ActionResult Index()
        {
            //CreateDal();
            //  CreateModel();
            CreateController();
            return View();
        }
        /// <summary>
        /// 生成model
        /// </summary>
        /// <returns></returns>
        public String CreateModel()
        {
    
            builderModel = new BuilderCSharpModel();
            var tables = db.GetTableViews(dbName);
            if (tables == null)
            {
                return "数据库表为空";
            }
            foreach (var item in tables)
            {
                List<ColumnInfo> list = db.GetColumnInfoList(dbName, item);
                builderModel.Fieldlist = list;
                builderModel.ModelName = item;
                builderModel.BaseClass = "BaseModel";
                DataRow tableDescRow = db.GetTablesExProperty(dbName).Select("objname='" + item + "'").FirstOrDefault();
                if (tableDescRow != null) { 
                builderModel.TableDescription = tableDescRow["value"]?.ToString();
                }
                string modelStr=  builderModel.CreatModel();
                Utils.CreateFile("/code/Model", item+".cs", modelStr);
            }

            return "生成成功";
        }
        public string CreateDal() {
        
            builderDAL = new BuilderCSharpDAL();
            var tables = db.GetTableViews(dbName);
            if (tables == null)
            {
                return "数据库表为空";
            }
            foreach (var item in tables)
            {
                string dalName = item.Replace("tb", "D");
                List<ColumnInfo> list = db.GetColumnInfoList(dbName, item);
                builderDAL.Fieldlist = list;
                builderDAL.TableName = item;
                builderDAL.ModelName = item;
                builderDAL.Modelpath = "Model";
                builderDAL.DbObject = db;
                builderDAL.Keys = list.Where(a=>a.IsPrimaryKey).ToList();
                builderDAL.DALpath = "DAL";
                builderDAL.DALName = dalName;
                string dalStr = builderDAL.GetDALCode(false, true, true, true, true, true, true);
                Utils.CreateFile("/code/DAL", dalName + ".cs", dalStr);
            }
            return "生成成功";
        }

        public string CreateController()
        {

            BuilderMvcController builderController = new BuilderMvcController();
            var tables = db.GetTableViews(dbName);
            if (tables == null)
            {
                return "数据库表为空";
            }
            foreach (var item in tables)
            {
                string actionName = item.Replace("tb_", "");
                List<ColumnInfo> list = db.GetColumnInfoList(dbName, item);
                builderController.ModelName = item;
                builderController.ActionName = actionName;
                builderController.Fieldlist = list;
                DataRow tableDescRow = db.GetTablesExProperty(dbName).Select("objname='" + item + "'").FirstOrDefault();
                if (tableDescRow != null)
                {
                    builderController.TableDescription = tableDescRow["value"]?.ToString();
                }
                builderController.BaseClass = "Controller";
                Utils.CreateFile("/code/Controllers", actionName + "Controller.cs", builderController.CreatController());
            }
            return "生成成功";
        }
    }
}