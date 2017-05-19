using System;
using Asi;
using Asi.Web.UI.WebControls;

namespace $safeprojectname$
{
    public partial class $safeprojectname$Display : iPartDisplayBase
    {
        #region Event Handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!IsPostBack)
                OneTimeInitializations();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (DoNotRenderInDesignMode && IsContentDesignMode)
                HideContent = true;
            else
                HideContent = false;

            // TODO: Remove this and add your own business logic.
            if (ExampleShowUserId)
            {
                ExampleCurrentUser.Visible = true;
                ExampleCurrentUser.Text = AppContext.CurrentIdentity.LoginUserId;
            }
            else
                ExampleCurrentUser.Visible = false;
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // This is sample code that shows how to add a command button to the header area, and how to add
            // an optional command to the 'Options' dropdown.
            // Initialize command buttons and dropdown commands
            if (!IsContentDesignMode)
            {
                // Create an 'Edit' command button                
                // Note that the button images are specified in a .skin file, with a SkinID that matches the SkinID below                
                var commandItem = new PanelTemplateCommandItem
                {
                    SkinID = "PanelCommandButtonEdit", 
                    ToolTip = "This is a tooltip for the edit command button",
                    ClientScriptToExecute = @"javascript:ShowDialog('default.aspx', null, 400, 400, 'Edit', null, 'E', WindowEdit_Callback_" + 
                    ClientID + @", null, false, true, null, null);", 
                    ClientScriptToRender = @"
                        function WindowEdit_Callback_" + ClientID + @"(dialogWindow)
                        {                            
                            alert('Callback method for edit button is executing');
                        }"
                }; 
                PanelTemplateControl.Commands.Add(commandItem);

                var optionalCommandItem = new PanelTemplateOptionalCommandItem
                {
                    Text = "Design",
                    ToolTip = "This is a tooltip for the design option",
                    ClientScriptToExecute = @"javascript:ShowDialog('default.aspx', null, 400, 400, 'Edit', null, 'E', WindowDesign_Callback_" +
                      ClientID + @", null, false, true, null, null);",
                    ClientScriptToRender = @"
                        function WindowDesign_Callback_" + ClientID + @"(dialogWindow)
                        {                            
                            alert('Callback method for design option is executing');
                        }"
                };
                PanelTemplateControl.OptionalCommands.Add(optionalCommandItem);
                ////////////////////////////////////////////////////////////////////////////////////////////////////

            }
        }

        #endregion

        #region Properties

        // TODO: Remove this example property, and add your configuration properties here.

        /// <summary>
        /// Enables/disables the display of the current user.
        /// </summary>
        public bool ExampleShowUserId
        {
            get
            {
                if (ViewState["ExampleShowUserId"] == null)
                    return true;

                return (bool)ViewState["ExampleShowUserId"];
            }
            set
            {
                ViewState["ExampleShowUserId"] = value;
            }
        }


        #endregion

        #region Methods

        /// <summary>
        /// Create the appropriate object
        /// </summary>
        /// <returns></returns>
        public override Asi.Business.ContentManagement.ContentItem CreateContentItem()
        {
            var item = new $safeprojectname$Common { ContentItemKey = ContentItemKey };
            return item;
        }

        /// <summary>
        /// Logic that will execute on initial page load
        /// </summary>
        private void OneTimeInitializations()
        {            
        }

        #endregion

        #region Method Overrides

        /// <summary>
        /// Called on the connection consumer. This method will act on the object passed in from
        /// the connection provider.
        /// </summary>
        /// <param name="providerObject">Object passed in from the connection provider.</param>
        public override void SetObjectProviderData(Object providerObject)
        {
            // TODO: If this iPart is to be a connection consumer, add code here to act on the
            // object passed in from the connection provider. Note that other connection types 
            // are available, see SetAtomObjectProviderData, SetUniformKeyProviderData, 
            // SetStringKeyProviderData.
        }

        /// <summary>
        /// Called on the connection provider. 
        /// </summary>
        /// <returns>An object that will be acted on by the connection consumer.</returns>
        public override Object GetObjectProviderData()
        {
            // TODO: If this iPart is to be a connection provider, add code here to return
            // an object that will be acted on by the connection consumer. Note that other connection 
            // types are available, see GetAtomObjectProviderData, GetUniformKeyProviderData, 
            // GetStringKeyProviderData.
            return null;
        }

        #endregion Method Overrides

        #region Static Methods

        #endregion
    }
}