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
    public class Project
    {
        public Guid ProjectId { get; private set; }
        public Guid ModifiedBy;
        public Guid CreatedBy;
        public Guid? AccountId;
        public string Name;
        public string Detail;
        public DateTime ModifiedOn;
        public DateTime CreatedOn;
        public DateTime? DueDate;

        public bool IsExistingRecord { get; private set; }

        public Project()
        {
            IsExistingRecord = false;

            this.ProjectId = Guid.NewGuid();
        }

        public Project(Guid projectId)
        {
            IsExistingRecord = true;
            this.ProjectId = projectId;

            DataRow _dataRow = GetDetail().Rows[0];
            StringParser.Parse(_dataRow["AccountId"].ToString(), out this.AccountId);
            StringParser.Parse(_dataRow["Name"].ToString(), out this.Name);
            StringParser.Parse(_dataRow["Detail"].ToString(), out this.Detail);
            StringParser.Parse(_dataRow["DueDate"].ToString(), out this.DueDate);
            StringParser.Parse(_dataRow["ModifiedBy"].ToString(), out this.ModifiedBy);
            StringParser.Parse(_dataRow["CreatedBy"].ToString(), out this.CreatedBy);
            StringParser.Parse(_dataRow["ModifiedOn"].ToString(), out this.ModifiedOn);
            StringParser.Parse(_dataRow["CreatedOn"].ToString(), out this.CreatedOn);
        }

        public void SaveToDataBase(Guid modifiedBy)
        {
            if (IsExistingRecord)
            {
                this.ModifiedBy = modifiedBy;
                this.ModifiedOn = DateTime.Now;

                Update();
            }
            else
            {
                this.CreatedBy = modifiedBy;
                this.CreatedOn = DateTime.Now;
                this.ModifiedBy = modifiedBy;
                this.ModifiedOn = DateTime.Now;

                Insert();
                IsExistingRecord = true;
            }
        }

        public void DeleteFromDatabase()
        {
            Delete();
            IsExistingRecord = false;
        }

        private Int32 Insert()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectId", this.ProjectId);
            parameterList.Add("@AccountId", this.AccountId);
            parameterList.Add("@Name", this.Name);
            parameterList.Add("@Detail", this.Detail);
            parameterList.Add("@DueDate", this.DueDate);
            parameterList.Add("@CreatedBy", this.CreatedBy);
            parameterList.Add("@CreatedOn", this.CreatedOn);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_ProjectInsert]", parameterList);
        }

        private Int32 Update()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectId", this.ProjectId);
            parameterList.Add("@AccountId", this.AccountId);
            parameterList.Add("@Name", this.Name);
            parameterList.Add("@Detail", this.Detail);
            parameterList.Add("@DueDate", this.DueDate);
            parameterList.Add("@ModifiedBy", this.ModifiedBy);
            parameterList.Add("@ModifiedOn", this.ModifiedOn);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_ProjectUpdate]", parameterList);
        }

        private Int32 Delete()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectId", this.ProjectId);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_ProjectDelete]", parameterList);
        }

        private DataTable GetDetail()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectId", this.ProjectId);
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_ProjectGetDetail]", parameterList);
        }

        public static DataTable GetAll()
        {
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_ProjectGetAll]");
        }
    }
}
