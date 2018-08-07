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
using Microsoft.ResourceManagement.WebServices.WSResourceManagement;
using System.Collections.ObjectModel;
using Microsoft.ResourceManagement.Workflow.Activities;

namespace FIM.AssignCostCenterManagerActivity
{
    public partial class AssignCostCenterManagerActivity : SequenceActivity
    {
        private static readonly Guid FIMADMGUID = new Guid("4074f258-a177-42df-b8ca-cba1a0cefb25");

        private Guid _requestor;
        private Guid _target;
        private Guid _costCenter;
        private string _costCenterCode;
        private bool _cccExists;
        private string _manager;

        public AssignCostCenterManagerActivity()
        {
            InitializeComponent();
        }

        #region CurrentRequest
        public static DependencyProperty CurrentRequest_CurrentRequest1Property = DependencyProperty.Register("CurrentRequest_CurrentRequest1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType CurrentRequest_CurrentRequest1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.RequestType)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.CurrentRequest_CurrentRequest1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.CurrentRequest_CurrentRequest1Property, value);
            }
        }
        #endregion

        #region ReadUser
        public static DependencyProperty ReadUser_ActorId1Property = DependencyProperty.Register("ReadUser_ActorId1", typeof(System.Guid), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid ReadUser_ActorId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadUser_ActorId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadUser_ActorId1Property, value);
            }
        }

        public static DependencyProperty ReadUser_Resource1Property = DependencyProperty.Register("ReadUser_Resource1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType ReadUser_Resource1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadUser_Resource1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadUser_Resource1Property, value);
            }
        }

        public static DependencyProperty ReadUser_ResourceId1Property = DependencyProperty.Register("ReadUser_ResourceId1", typeof(System.Guid), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid ReadUser_ResourceId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadUser_ResourceId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadUser_ResourceId1Property, value);
            }
        }

        public static DependencyProperty ReadUser_SelectionAttributes1Property = DependencyProperty.Register("ReadUser_SelectionAttributes1", typeof(System.String[]), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public String[] ReadUser_SelectionAttributes1
        {
            get
            {
                return ((string[])(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadUser_SelectionAttributes1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadUser_SelectionAttributes1Property, value);
            }
        }
        #endregion

        #region FindCostCenterGuid
        public static DependencyProperty FindCostCenter_ActorId1Property = DependencyProperty.Register("FindCostCenter_ActorId1", typeof(System.Guid), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Guid FindCostCenter_ActorId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_ActorId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_ActorId1Property, value);
            }
        }

        public static DependencyProperty FindCostCenter_PageSize1Property = DependencyProperty.Register("FindCostCenter_PageSize1", typeof(System.Int32), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Int32 FindCostCenter_PageSize1
        {
            get
            {
                return ((int)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_PageSize1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_PageSize1Property, value);
            }
        }

        public static DependencyProperty FindCostCenter_Selection1Property = DependencyProperty.Register("FindCostCenter_Selection1", typeof(System.String[]), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public String[] FindCostCenter_Selection1
        {
            get
            {
                return ((string[])(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_Selection1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_Selection1Property, value);
            }
        }

        public static DependencyProperty FindCostCenter_SortingAttributes1Property = DependencyProperty.Register("FindCostCenter_SortingAttributes1", typeof(Microsoft.ResourceManagement.WebServices.WSEnumeration.SortingAttribute[]), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Microsoft.ResourceManagement.WebServices.WSEnumeration.SortingAttribute[] FindCostCenter_SortingAttributes1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSEnumeration.SortingAttribute[])(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_SortingAttributes1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_SortingAttributes1Property, value);
            }
        }

        public static DependencyProperty FindCostCenter_TotalResultsCount1Property = DependencyProperty.Register("FindCostCenter_TotalResultsCount1", typeof(System.Int32), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public Int32 FindCostCenter_TotalResultsCount1
        {
            get
            {
                return ((int)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_TotalResultsCount1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_TotalResultsCount1Property, value);
            }
        }

        public static DependencyProperty FindCostCenter_XPathFilter1Property = DependencyProperty.Register("FindCostCenter_XPathFilter1", typeof(System.String), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Misc")]
        public String FindCostCenter_XPathFilter1
        {
            get
            {
                return ((string)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_XPathFilter1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.FindCostCenter_XPathFilter1Property, value);
            }
        }
        #endregion

        #region ReadCostCenter
        public static DependencyProperty ReadCostCenter_ActorId1Property = DependencyProperty.Register("ReadCostCenter_ActorId1", typeof(System.Guid), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid ReadCostCenter_ActorId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadCostCenter_ActorId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadCostCenter_ActorId1Property, value);
            }
        }

        public static DependencyProperty ReadCostCenter_Resource1Property = DependencyProperty.Register("ReadCostCenter_Resource1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public ResourceType ReadCostCenter_Resource1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.ResourceType)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadCostCenter_Resource1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadCostCenter_Resource1Property, value);
            }
        }

        public static DependencyProperty ReadCostCenter_ResourceId1Property = DependencyProperty.Register("ReadCostCenter_ResourceId1", typeof(System.Guid), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid ReadCostCenter_ResourceId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadCostCenter_ResourceId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadCostCenter_ResourceId1Property, value);
            }
        }

        public static DependencyProperty ReadCostCenter_SelectionAttributes1Property = DependencyProperty.Register("ReadCostCenter_SelectionAttributes1", typeof(System.String[]), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public String[] ReadCostCenter_SelectionAttributes1
        {
            get
            {
                return ((string[])(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadCostCenter_SelectionAttributes1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.ReadCostCenter_SelectionAttributes1Property, value);
            }
        }
        #endregion

        #region UpdateUser
        public static DependencyProperty UpdateUser_ActorId1Property = DependencyProperty.Register("UpdateUser_ActorId1", typeof(System.Guid), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid UpdateUser_ActorId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_ActorId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_ActorId1Property, value);
            }
        }

        public static DependencyProperty UpdateUser_ApplyAuthorizationPolicy1Property = DependencyProperty.Register("UpdateUser_ApplyAuthorizationPolicy1", typeof(System.Boolean), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Boolean UpdateUser_ApplyAuthorizationPolicy1
        {
            get
            {
                return ((bool)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_ApplyAuthorizationPolicy1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_ApplyAuthorizationPolicy1Property, value);
            }
        }

        public static DependencyProperty UpdateUser_ResourceId1Property = DependencyProperty.Register("UpdateUser_ResourceId1", typeof(System.Guid), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Guid UpdateUser_ResourceId1
        {
            get
            {
                return ((System.Guid)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_ResourceId1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_ResourceId1Property, value);
            }
        }

        public static DependencyProperty UpdateUser_UpdateParameters1Property = DependencyProperty.Register("UpdateUser_UpdateParameters1", typeof(Microsoft.ResourceManagement.WebServices.WSResourceManagement.UpdateRequestParameter[]), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public UpdateRequestParameter[] UpdateUser_UpdateParameters1
        {
            get
            {
                return ((Microsoft.ResourceManagement.WebServices.WSResourceManagement.UpdateRequestParameter[])(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_UpdateParameters1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_UpdateParameters1Property, value);
            }
        }

        public static DependencyProperty UpdateUser_AuthorizationWaitTimeInSeconds1Property = DependencyProperty.Register("UpdateUser_AuthorizationWaitTimeInSeconds1", typeof(System.Int32), typeof(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("Parameters")]
        public Int32 UpdateUser_AuthorizationWaitTimeInSeconds1
        {
            get
            {
                return ((int)(base.GetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_AuthorizationWaitTimeInSeconds1Property)));
            }
            set
            {
                base.SetValue(FIM.AssignCostCenterManagerActivity.AssignCostCenterManagerActivity.UpdateUser_AuthorizationWaitTimeInSeconds1Property, value);
            }
        }
        #endregion

        private void InitReadUser_ExecuteCode(object sender, EventArgs e)
        {
            RequestType currentRequest = this.CurrentRequest.CurrentRequest;
            ReadOnlyCollection<CreateRequestParameter> requestParameters = currentRequest.ParseParameters<CreateRequestParameter>();

            // Retrieve current workflow
            SequentialWorkflow workflow = null;
            if (!SequentialWorkflow.TryGetContainingWorkflow(this, out workflow))
            {
                throw new InvalidOperationException();
            }

            // Save information
            _requestor = workflow.ActorId;
            _target = workflow.TargetId;

            // Init ReadUser activity
            this.ReadUser_ActorId1 = FIMADMGUID;
            this.ReadUser_ResourceId1 = _target;
        }

        private void InitFindCostCenterGuid_ExecuteCode(object sender, EventArgs e)
        {
            // Get cost center code
            _costCenterCode = ReadUser.Resource["CostCenterCode"].ToString();

            // Init FindCostCenter activity
            this.FindCostCenter_ActorId1 = FIMADMGUID;
            this.FindCostCenter_PageSize1 = 100;
            this.FindCostCenter_XPathFilter1 = "/labCostCenter[Cost Center=" + _costCenterCode + "]";
        }

        private void InitIfElseActivity1_ExecuteCode(object sender, EventArgs e)
        {
            // Check results
            _cccExists = this.FindCostCenter_TotalResultsCount1 == 1;
        }

        private void InitReadCostCenter_ExecuteCode(object sender, EventArgs e)
        {
            RequestType costCenterRequest = EnumerateResourcesActivity.GetCurrentIterationItem((CodeActivity)sender) as RequestType;
            _costCenter = costCenterRequest.ObjectID.GetGuid();

            // Init ReadCostCenter activity
            this.ReadCostCenter_ActorId1 = FIMADMGUID;
            this.ReadCostCenter_ResourceId1 = _costCenter;
        }

        private void InitUpdateUser_ExecuteCode(object sender, EventArgs e)
        {
            _manager = this.ReadCostCenter.Resource["Manager"].ToString();

            // Init UpdateUser activity
            this.UpdateUser_ActorId1 = _requestor;
            this.UpdateUser_ResourceId1 = _target;
            this.UpdateUser_UpdateParameters1 = new UpdateRequestParameter[] {
                new UpdateRequestParameter("Manager", UpdateMode.Modify, _manager)
            };
        }
    }
}
