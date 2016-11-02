using PensionConsultants.Data.Utilities;
using RfpTool.Business.Components;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfpTool.Business.Entities
{
    public class StringMap
    {
        public Guid StringMapId;
        public Guid ModifiedBy;
        public Guid CreatedBy;
        public string StringValue;
        public string ColumnName;
        public string TableName;
        public DateTime ModifiedOn;
        public DateTime CreatedOn;

        private bool IsExistingRecord;

        public StringMap()
        {
            IsExistingRecord = false;

            StringMapId = Guid.NewGuid();
        }

        public StringMap(Guid _stringMapId)
        {
            IsExistingRecord = true;

            DataRow _dataRow = GetDetail(_stringMapId).Rows[0];
            StringParser.Parse(_dataRow["StringMapId"].ToString(), out this.StringMapId);
            StringParser.Parse(_dataRow["StringValue"].ToString(), out this.StringValue);
            StringParser.Parse(_dataRow["ModifiedBy"].ToString(), out this.ModifiedBy);
            StringParser.Parse(_dataRow["CreatedBy"].ToString(), out this.CreatedBy);
            StringParser.Parse(_dataRow["ModifiedOn"].ToString(), out this.ModifiedOn);
            StringParser.Parse(_dataRow["CreatedOn"].ToString(), out this.CreatedOn);
        }

        public static List<StringMap> GetListAssociatedFromColumn(string _tableName, string _columnName)
        {
            List<StringMap> _list = new List<StringMap>();

            foreach (DataRow _dataRow in GetDataTableAssociatedFromColumn(_tableName, _columnName).Rows)
            {
                Guid _stringMapId = new Guid(_dataRow["StringMapId"].ToString());
                StringMap _stringMap = new StringMap(_stringMapId);
                _list.Add(_stringMap);
            }

            return _list;
        }

        public static DataTable GetDataTableAssociatedFromColumn(string _tableName, string _columnName)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TableName", _tableName);
            parameterList.Add("@ColumnName", _columnName);
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_StringMapGetAssociatedFromColumn]", parameterList);
        }

        public void SaveToDataBase(Guid _modifiedBy)
        {
            if (IsExistingRecord)
            {
                Update(_modifiedBy);
            }
            else
            {
                Insert(_modifiedBy);
                IsExistingRecord = true;
            }
        }

        public void DeleteFromDatabase()
        {
            Delete();
            IsExistingRecord = false;
        }

        private Int32 Insert(Guid _createdBy)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@CreatedBy", _createdBy);
            parameterList.Add("@StringValue", this.StringValue);
            parameterList.Add("@TableName", this.TableName);
            parameterList.Add("@ColumnName", this.ColumnName);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_StringMapInsert]", parameterList);
        }

        private Int32 Update(Guid _modifiedBy)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@StringMapId", this.StringMapId);
            parameterList.Add("@ModifiedBy", _modifiedBy);
            parameterList.Add("@StringValue", this.StringValue);
            parameterList.Add("@TableName", this.TableName);
            parameterList.Add("@ColumnName", this.ColumnName);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_StringMapUpdate]", parameterList);
        }

        private Int32 Delete()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@StringMapId", this.StringMapId);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_StringMapDelete]", parameterList);
        }

        private DataTable GetDetail(Guid _stringMapId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@StringMapId", _stringMapId);
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_StringMapGetDetail]", parameterList);
        }
    }
}
