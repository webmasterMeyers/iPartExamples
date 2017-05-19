using System;
using System.Runtime.Serialization;
using Asi;
using Asi.Business.ContentManagement;
using Asi.Business.ContentManagement.ContentType;

namespace $safeprojectname$
{
    /// <summary>
    /// Implements base logic for the $safeprojectname$ iPart.
    /// </summary>
    [DataContract(Name = "$safeprojectname$")]
    public class $safeprojectname$Common : iPartCommonBase
    {
        private readonly bool mIsNew;

        #region Constructors

        /// <summary>
        /// Creates a new $safeprojectname$Common object.
        /// </summary>
        public $safeprojectname$Common()
        {
            mIsNew = true;

            // TODO: Remove this, and set your property default values here.
            ExampleShowUserId = true;
        }

        /// <summary>
        /// Creates a new $safeprojectname$Common object.
        /// </summary>
        /// <param name="contentKey"></param>
        public $safeprojectname$Common(Guid contentKey) : base(contentKey) { }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the ContentTypeKey for the ContentTypeRegistry object that represents this content type.
        /// </summary>
        public override Guid ContentTypeKey
        {
            get
            {
                // TODO: Define your Content Type in iMIS (Content Manager->Maintenance->Content types)
                // TODO: Once the Content Type is defined, copy and paste its ContentKey value here.
                return new Guid("00000000-0000-0000-0000-000000000000");
            }
        }

        /// <summary>
        /// Whether this is a newly created ContentItem or not.
        /// </summary>
        public override bool IsNew
        {
            get
            {
                return mIsNew;
            }
        }

        // TODO: Remove this example property, and add your configuration properties here...

        /// <summary>
        /// Example configuration option. Enables/disables the display of the current user. 
        /// </summary>
        [DataMember(Name = "ExampleShowUserId")]
        public bool ExampleShowUserId { get; set; }



        #endregion Properties

        #region Methods

        /// <summary>
        /// Reads current Property values
        /// </summary>
        /// <returns></returns>
        public override ContentParameterCollection GetCurrentParameterValues()
        {
            ContentParameterCollection collection = base.GetCurrentParameterValues();
            // TODO: Remove this line, and add a line for each of your configuration properties
            collection.Add("ExampleShowUserId", ExampleShowUserId);

            return collection;
        }
        
        /// <summary>
        /// Configure and set display for CONFIGURATION PAGE
        /// </summary>
        /// <param name="ap"></param>
        public override void ConfigureAtomProperty(Asi.Atom.AtomProperty ap)
        {
            base.ConfigureAtomProperty(ap);

            switch (ap.Name)
            {
                // TODO: Remove this 'case' and add a 'case' for each of your configuration properties.
                case "ExampleShowUserId":
                    ap.Caption = ResourceManager.GetPhrase("Asi.Web.iParts.ExampleShowUserId", 
                        "Enable display of the current user ID.");
                    break;
                default:
                    break;

            }
        }

        #endregion

        #region Static Methods

        #endregion

    }

}
