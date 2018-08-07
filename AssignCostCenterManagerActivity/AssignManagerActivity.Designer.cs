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
    public partial class AssignManagerActivity
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
            this.currentRequestActivity1 = new Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity();
            // 
            // currentRequestActivity1
            // 
            activitybind1.Name = "AssignManagerActivity";
            activitybind1.Path = "currentRequestActivity1_CurrentRequest1";
            this.currentRequestActivity1.Name = "currentRequestActivity1";
            this.currentRequestActivity1.SetBinding(Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity.CurrentRequestProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // AssignManagerActivity
            // 
            this.Activities.Add(this.currentRequestActivity1);
            this.Name = "AssignManagerActivity";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.ResourceManagement.Workflow.Activities.CurrentRequestActivity currentRequestActivity1;

    }
}
