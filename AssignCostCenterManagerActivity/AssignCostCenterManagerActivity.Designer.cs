using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Reflection;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace FIM.AssignCostCenterManagerActivity
{
    public partial class AssignCostCenterManagerActivity
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("", "")]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind13 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind14 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind15 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind16 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind17 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind18 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind19 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind20 = new System.Workflow.ComponentModel.ActivityBind();
            this.UpdateUser = new Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity();
            this.InitUpdateUser = new System.Workflow.Activities.CodeActivity();
            this.Iterate_Enum = new System.Workflow.Activities.CodeActivity();
            this.ReadCostCenter = new Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity();
            this.InitReadCostCenter = new System.Workflow.Activities.CodeActivity();
            this.CostCenterNotFound = new System.Workflow.Activities.IfElseBranchActivity();
            this.CostCenterFound = new System.Workflow.Activities.IfElseBranchActivity();
            this.CostCenterExists = new System.Workflow.Activities.IfElseActivity();
            this.InitIfElseActivity1 = new System.Workflow.Activities.CodeActivity();
            this.FindCostCenterGuid = new Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity();
            this.InitFindCostCenterGuid = new System.Workflow.Activities.CodeActivity();
            this.ReadUser = new Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity();
            this.InitReadUser = new System.Workflow.Activities.CodeActivity();
            this.CurrentRequest = new Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity();
            // 
            // UpdateUser
            // 
            activitybind1.Name = "AssignCostCenterManagerActivity";
            activitybind1.Path = "UpdateUser_ActorId1";
            activitybind2.Name = "AssignCostCenterManagerActivity";
            activitybind2.Path = "UpdateUser_ApplyAuthorizationPolicy1";
            activitybind3.Name = "AssignCostCenterManagerActivity";
            activitybind3.Path = "UpdateUser_AuthorizationWaitTimeInSeconds1";
            this.UpdateUser.Name = "UpdateUser";
            activitybind4.Name = "AssignCostCenterManagerActivity";
            activitybind4.Path = "UpdateUser_ResourceId1";
            activitybind5.Name = "AssignCostCenterManagerActivity";
            activitybind5.Path = "UpdateUser_UpdateParameters1";
            this.UpdateUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.ActorIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.UpdateUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.ApplyAuthorizationPolicyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.UpdateUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.ResourceIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.UpdateUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.UpdateParametersProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.UpdateUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity.AuthorizationWaitTimeInSecondsProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // InitUpdateUser
            // 
            this.InitUpdateUser.Name = "InitUpdateUser";
            this.InitUpdateUser.ExecuteCode += new System.EventHandler(this.InitUpdateUser_ExecuteCode);
            // 
            // InitIterate_Enum
            // 
            this.Iterate_Enum.Name = "Iterate_Enum";
            this.Iterate_Enum.ExecuteCode += new System.EventHandler(this.Iterate_Enum_ExecuteCode);
            // 
            // ReadCostCenter
            //
            activitybind6.Name = "AssignCostCenterManagerActivity";
            activitybind6.Path = "ReadCostCenter_ActorId1";
            this.ReadCostCenter.Name = "ReadCostCenter";
            activitybind7.Name = "AssignCostCenterManagerActivity";
            activitybind7.Path = "ReadCostCenter_Resource1";
            activitybind8.Name = "AssignCostCenterManagerActivity";
            activitybind8.Path = "ReadCostCenter_ResourceId1";
            activitybind9.Name = "AssignCostCenterManagerActivity";
            activitybind9.Path = "ReadCostCenter_SelectionAttributes1";
            this.ReadCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ActorIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.ReadCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ResourceProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.ReadCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ResourceIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            this.ReadCostCenter.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.SelectionAttributesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            // 
            // InitReadCostCenter
            // 
            this.InitReadCostCenter.Name = "InitReadCostCenter";
            this.InitReadCostCenter.ExecuteCode += new System.EventHandler(this.InitReadCostCenter_ExecuteCode);
            // 
            // CostCenterNotFound
            // 
            this.CostCenterNotFound.Name = "CostCenterNotFound";
            // 
            // CostCenterFound
            // 
            this.CostCenterFound.Activities.Add(this.InitReadCostCenter);
            this.CostCenterFound.Activities.Add(this.ReadCostCenter);
            this.CostCenterFound.Activities.Add(this.InitUpdateUser);
            this.CostCenterFound.Activities.Add(this.UpdateUser);
            ruleconditionreference1.ConditionName = "Condition1";
            this.CostCenterFound.Condition = ruleconditionreference1;
            this.CostCenterFound.Name = "CostCenterFound";
            // 
            // CostCenterExists
            // 
            this.CostCenterExists.Activities.Add(this.CostCenterFound);
            this.CostCenterExists.Activities.Add(this.CostCenterNotFound);
            this.CostCenterExists.Name = "CostCenterExists";
            // 
            // InitIfElseActivity1
            // 
            this.InitIfElseActivity1.Name = "InitIfElseActivity1";
            this.InitIfElseActivity1.ExecuteCode += new System.EventHandler(this.InitIfElseActivity1_ExecuteCode);
            // 
            // FindCostCenterGuid
            // 
            this.FindCostCenterGuid.Activities.Add(this.Iterate_Enum);
            activitybind10.Name = "AssignCostCenterManagerActivity";
            activitybind10.Path = "FindCostCenter_ActorId1";
            this.FindCostCenterGuid.Name = "FindCostCenterGuid";
            activitybind11.Name = "AssignCostCenterManagerActivity";
            activitybind11.Path = "FindCostCenter_PageSize1";
            activitybind12.Name = "AssignCostCenterManagerActivity";
            activitybind12.Path = "FindCostCenter_Selection1";
            activitybind13.Name = "AssignCostCenterManagerActivity";
            activitybind13.Path = "FindCostCenter_SortingAttributes1";
            activitybind14.Name = "AssignCostCenterManagerActivity";
            activitybind14.Path = "FindCostCenter_TotalResultsCount1";
            activitybind15.Name = "AssignCostCenterManagerActivity";
            activitybind15.Path = "FindCostCenter_XPathFilter1";
            this.FindCostCenterGuid.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.ActorIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
            this.FindCostCenterGuid.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.PageSizeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
            this.FindCostCenterGuid.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.SelectionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
            this.FindCostCenterGuid.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.SortingAttributesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind13)));
            this.FindCostCenterGuid.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.TotalResultsCountProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind14)));
            this.FindCostCenterGuid.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity.XPathFilterProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind15)));
            // 
            // InitFindCostCenterGuid
            // 
            this.InitFindCostCenterGuid.Name = "InitFindCostCenterGuid";
            this.InitFindCostCenterGuid.ExecuteCode += new System.EventHandler(this.InitFindCostCenterGuid_ExecuteCode);
            // 
            // ReadUser
            // 
            activitybind16.Name = "AssignCostCenterManagerActivity";
            activitybind16.Path = "ReadUser_ActorId1";
            this.ReadUser.Name = "ReadUser";
            activitybind17.Name = "AssignCostCenterManagerActivity";
            activitybind17.Path = "ReadUser_Resource1";
            activitybind18.Name = "AssignCostCenterManagerActivity";
            activitybind18.Path = "ReadUser_ResourceId1";
            activitybind19.Name = "AssignCostCenterManagerActivity";
            activitybind19.Path = "ReadUser_SelectionAttributes1";
            this.ReadUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ActorIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind16)));
            this.ReadUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ResourceProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind17)));
            this.ReadUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.ResourceIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind18)));
            this.ReadUser.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity.SelectionAttributesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind19)));
            // 
            // InitReadUser
            // 
            this.InitReadUser.Name = "InitReadUser";
            this.InitReadUser.ExecuteCode += new System.EventHandler(this.InitReadUser_ExecuteCode);
            // 
            // CurrentRequest
            // 
            activitybind20.Name = "AssignCostCenterManagerActivity";
            activitybind20.Path = "CurrentRequest_CurrentRequest1";
            this.CurrentRequest.Name = "CurrentRequest";
            this.CurrentRequest.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity.CurrentRequestProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind20)));
            // 
            // AssignCostCenterManagerActivity
            // 
            this.Activities.Add(this.CurrentRequest);
            this.Activities.Add(this.InitReadUser);
            this.Activities.Add(this.ReadUser);
            this.Activities.Add(this.InitFindCostCenterGuid);
            this.Activities.Add(this.FindCostCenterGuid);
            this.Activities.Add(this.InitIfElseActivity1);
            this.Activities.Add(this.CostCenterExists);
            this.Name = "AssignCostCenterManagerActivity";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.ResourceManagement.Workflow.Activities.UpdateResourceActivity UpdateUser;

        private CodeActivity InitUpdateUser;

        private CodeActivity Iterate_Enum;

        private Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity ReadCostCenter;

        private CodeActivity InitReadCostCenter;

        private IfElseBranchActivity CostCenterNotFound;

        private IfElseBranchActivity CostCenterFound;

        private IfElseActivity CostCenterExists;

        private CodeActivity InitIfElseActivity1;

        private Microsoft.ResourceManagement.Workflow.Activities.EnumerateResourcesActivity FindCostCenterGuid;

        private CodeActivity InitFindCostCenterGuid;

        private Microsoft.ResourceManagement.Workflow.Activities.ReadResourceActivity ReadUser;

        private CodeActivity InitReadUser;

        private Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity CurrentRequest;
















    }
}
