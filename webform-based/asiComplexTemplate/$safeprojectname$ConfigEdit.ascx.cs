using Asi.Web.UI.WebControls;
using System;
using System.Collections.Generic;

namespace $safeprojectname$
{
    public partial class $safeprojectname$ConfigEdit : iPartEditBase
    {

        /// <summary>
        /// Name of atom component that this control will bind to.
        /// </summary>
        public override string AtomComponentName
        {
            get
            {
                // TODO:
                // This must match the 'Name of the Content Type' defined on the Content Type in
                // 'Content Manager->Maintenance->Content types'
                return "$safeprojectname$";
            }
        }
        protected override void OnInit(EventArgs e)
        {
            HideConfigurationOptions();
            base.OnInit(e);
        }
        private void HideConfigurationOptions()
        {
            if (HiddenConfigurationOptions == null)
                HiddenConfigurationOptions = new List<HideConfiguration>();
            // To Hide Default Options, uncomment lines below    
            // HiddenConfigurationOptions.Add(HideConfiguration.PartTitle);
            // HiddenConfigurationOptions.Add(HideConfiguration.CssClass);
            // HiddenConfigurationOptions.Add(HideConfiguration.ShowBorder);
            // HiddenConfigurationOptions.Add(HideConfiguration.Collapsible);
            // HiddenConfigurationOptions.Add(HideConfiguration.DisplayOnExtraSmallScreens);
            // HiddenConfigurationOptions.Add(HideConfiguration.DisplayOnSmallScreens);
            // HiddenConfigurationOptions.Add(HideConfiguration.DisplayOnMediumScreens);
            // HiddenConfigurationOptions.Add(HideConfiguration.DisplayOnLargeScreens);
            // HiddenConfigurationOptions.Add(HideConfiguration.DoNotRenderInDesignMode);
            // HiddenConfigurationOptions.Add(HideConfiguration.ModuleSpecificSetting);
            EnsureChildControls();
        }
    }
}
