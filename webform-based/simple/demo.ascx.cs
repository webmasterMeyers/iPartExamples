using System;
using Asi.Security.Utility;
using Asi.Soa.ClientServices;
using Asi.Soa.Core.DataContracts;
using Asi.Soa.Membership.DataContracts;

namespace DemoNamespace
{
    public partial class DemoClass : System.Web.UI.UserControl
    {
        public string html =  "<h1>Your Query Output</h1>";

        protected override void OnPreRender(EventArgs e)
        {
            // for access when user us un-authenticated (GUEST, not logged in)
            // uncomment next 3 lines, and remove or comment out the 4th
            // string userName = ""; // iMIS user name
            // string password = ""; // password
            // var entityManager = new EntityManager(userName, password);
            var entityManager = new EntityManager(Asi.AppContext.CurrentIdentity.LoginUserId);
            var query = new QueryData("PartySummary") { Pager = new PagerData { PageSize = 5 } };
            query.AddCriteria(CriteriaData.StartsWith("LastName", "smith"));

            // invoke the operation to get a list of PartySummary
            FindResultsData results2 = entityManager.Find(query);

            // loop through the pages
            while (results2.Query.Pager.PageNumber < results2.Query.Pager.PageCount)
            {
                html += "Page: " + results2.Query.Pager.PageNumber;

                // the returned Parties will be in in the results.Results list.
                foreach (PartySummaryData partySummary in results2.Result)
                {
                    html += "<br />Party: PartyId: " + partySummary.PartyId + ", Name: " + partySummary.Name;
                }

                results2.Query.Pager.PageNumber++;
                results2 = entityManager.Find(results2.Query);
                html += "</p>";
            }
            Output.Text = html;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ExampleCurrentUser.Text = "<h2>Some data that may be useful</h2>"
                + "for reference, the output of Asi.AppContext.CurrentIdentity.LoginUserId: " + Asi.AppContext.CurrentIdentity.LoginUserId
                + "<br /> and SecurityHelper.GetSelectedImisId(base.Request): " + SecurityHelper.GetSelectedImisId(base.Request)
                + "<br /> and SecurityHelper.LoggedInImisId: " + SecurityHelper.LoggedInImisId
                + "<br /> and SecurityHelper.IsAuthenticatedUser: " + SecurityHelper.IsAuthenticatedUser;
        }
    }
}