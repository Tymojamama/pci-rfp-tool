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
    public class Question
    {
        public Guid QuestionId;
        public Guid ModifiedBy;
        public Guid CreatedBy;
        public Guid? CategoryId;
        public string ComplianceId;
        public string Subject;
        public string Response;
        public DateTime ModifiedOn;
        public DateTime CreatedOn;

        private bool IsExistingRecord;

        public Question()
        {
            IsExistingRecord = false;
        }

        public Question(Guid _questionId)
        {
            IsExistingRecord = true;

            DataRow _dataRow = GetDetail(_questionId).Rows[0];
            StringParser.Parse(_dataRow["QuestionId"].ToString(), out this.QuestionId);
            StringParser.Parse(_dataRow["CategoryId"].ToString(), out this.CategoryId);
            StringParser.Parse(_dataRow["ComplianceId"].ToString(), out this.ComplianceId);
            StringParser.Parse(_dataRow["Subject"].ToString(), out this.Subject);
            StringParser.Parse(_dataRow["Response"].ToString(), out this.Response);
            StringParser.Parse(_dataRow["ModifiedBy"].ToString(), out this.ModifiedBy);
            StringParser.Parse(_dataRow["CreatedBy"].ToString(), out this.CreatedBy);
            StringParser.Parse(_dataRow["ModifiedOn"].ToString(), out this.ModifiedOn);
            StringParser.Parse(_dataRow["CreatedOn"].ToString(), out this.CreatedOn);
        }

        public static List<Question> AllQuestions()
        {
            List<Question> _list = new List<Question>();

            foreach (DataRow _dataRow in GetAll().Rows)
            {
                Guid _questionId = new Guid(_dataRow["QuestionId"].ToString());
                Question _question = new Question(_questionId);
                _list.Add(_question);
            }

            return _list;
        }

        public static DataTable GetAllQuestions()
        {
            return GetAll();
        }

        public void SaveToDataBase(Guid _userId)
        {
            if (IsExistingRecord)
            {
                Update(_userId);
            }
            else
            {
                Insert(_userId);
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
            parameterList.Add("@CategoryId", this.CategoryId);
            parameterList.Add("@ComplianceId", this.ComplianceId);
            parameterList.Add("@Subject", this.Subject);
            parameterList.Add("@Response", this.Response);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_QuestionInsert]", parameterList);
        }

        private Int32 Update(Guid _modifiedBy)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@QuestionId", this.QuestionId);
            parameterList.Add("@ModifiedBy", _modifiedBy);
            parameterList.Add("@CategoryId", this.CategoryId);
            parameterList.Add("@ComplianceId", this.ComplianceId);
            parameterList.Add("@Subject", this.Subject);
            parameterList.Add("@Response", this.Response);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_QuestionUpdate]", parameterList);
        }

        private Int32 Delete()
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@QuestionId", this.QuestionId);
            return Database.RfpTool.ExecuteStoredProcedureNonQuery("[dbo].[usp_QuestionDelete]", parameterList);
        }

        private static DataTable GetAll()
        {
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_QuestionGetAll]");
        }

        private DataTable GetDetail(Guid _questionId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@QuestionId", _questionId);
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_QuestionGetDetail]", parameterList);
        }

        public static DataTable Search(string searchText)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@SearchText", searchText);
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_QuestionSearch]", parameterList);
        }

        public static DataTable GetAssociated(StringMap stringMap)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@StringMapId", stringMap.StringMapId);
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_QuestionGetAssociatedFromStringMap]", parameterList);
        }

        public static DataTable GetAssociated(Project project)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@ProjectId", project.ProjectId);
            return Database.RfpTool.ExecuteStoredProcedureQuery("[dbo].[usp_QuestionGetAssociatedFromProject]", parameterList);
        }
    }
}
