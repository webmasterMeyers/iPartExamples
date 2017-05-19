using Asi.Web.UI.WebControls;

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
                // TODO: This must match the 'Name of the Content Type' defined on the Content Type in
                // TODO: 'Content Manager->Maintenance->Content types'
                return "$safeprojectname$";
            }
        }
    }
}