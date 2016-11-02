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
    public class ProjectQuestion
    {
        public Guid ProjectQuestionId { get; private set; }
        public Guid ProjectId;
        public Guid QuestionId;
        public Guid ModifiedBy;
        public Guid CreatedBy;
        public int Ordinal = 0;
        public DateTime ModifiedOn;
        public DateTime CreatedOn;

        private bool IsExistingRecord;

        public ProjectQuestion()
        {
            IsExistingRecord = false;

            this.ProjectQuestionId = Guid.NewGuid();
        }

        public ProjectQuestion(Guid projectQuestionid)
        {
            IsExistingRecord = true;
            this.ProjectQuestionId = projectQuestionid;

            DataRow _dataRow = GetDetail().Rows[0];
            StringParser.Parse(_dataRow["ProjectId"].ToString(), out this.ProjectId);
            StringParser.Parse(_dataRow["QuestionId"].ToString(), out this.QuestionId);
            StringParser.Parse(_dataRow["Ordinal"].ToString(), out this.Ordinal);
            StringParser.Parse(_dataRow["ModifiedBy"].ToString(), out this.ModifiedBy);
            StringParser.Parse(_dataRow["CreatedBy"].ToString(), out this.CreatedBy);
            StringParser.Parse(_dataRow["ModifiedOn"].ToString(), out this.ModifiedOn);
            StringParser.Parse(_dataRow["CreatedOn"].ToString(), out this.CreatedOn);
        }

        public ProjectQuestion(Guid projectId, Guid questionId)
        {
            IsExistingRecord = true;
            this.ProjectQuestionId = GetProjectQuestionId(projectId, questionId);

            DataRow _dataRow = GetDetail().Rows[0];
            StringParser.Parse(_dataRow["ProjectId"].ToString(), out this.ProjectId);
            StringParser.Parse(_dataRow["QuestionId"].ToString(), out this.QuestionId);
            StringParser.Parse(_dataRow["Ordinal"].ToString(), out this.Ordinal);
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
            parameterList.Add("@ProjectQuestionId", this.ProjectQuestionId);
            parameterList.Add("@ProjectId", this.ProjectId);
            parameterList.Add("@QuestionId", this.QuestionId);
            parameterList.Add("@Ordinal", this.Ordinal);
            parameterList.Add("@CreatedBy", this.CreatedBy);
            parameterList.Add("@CreatedOn", this.CreatedOn);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_ProjectQuestionInsert]", parameterList);
        }

        private Int32 Update()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectQuestionId", this.ProjectQuestionId);
            parameterList.Add("@ProjectId", this.ProjectId);
            parameterList.Add("@QuestionId", this.QuestionId);
            parameterList.Add("@Ordinal", this.Ordinal);
            parameterList.Add("@ModifiedBy", this.ModifiedBy);
            parameterList.Add("@ModifiedOn", this.ModifiedOn);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_ProjectQuestionUpdate]", parameterList);
        }

        private Int32 Delete()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectQuestionId", this.ProjectQuestionId);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_ProjectQuestionDelete]", parameterList);
        }

        private DataTable GetDetail()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectQuestionId", this.ProjectQuestionId);
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_ProjectQuestionGetDetail]", parameterList);
        }

        private Guid GetProjectQuestionId(Guid projectId, Guid questionId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectId", projectId);
            parameterList.Add("@QuestionId", questionId);
            DataTable dataTable = Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_ProjectQuestionGetProjectQuestionId]", parameterList);
            return new Guid(dataTable.Rows[0]["ProjectQuestionId"].ToString());
        }
    }
}
