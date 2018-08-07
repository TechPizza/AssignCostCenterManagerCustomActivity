using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Linq;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace FIM.AssignCostCenterManagerActivity
{
    public partial class AssignManagerActivity : SequenceActivity
    {
        #region currentRequest
        public static DependencyProperty currentRequestActivity1_CurrentRequest1Property = DependencyProperty.Register("currentRequestActivity1_CurrentRequest1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType), typeof(FIM.AssignCostCenterManagerActivity.AssignManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType currentRequestActivity1_CurrentRequest1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignManagerActivity.currentRequestActivity1_CurrentRequest1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignManagerActivity.currentRequestActivity1_CurrentRequest1Property, value);
            }
        }
        #endregion

        public AssignManagerActivity()
        {
            InitializeComponent();
        }
    }
}
