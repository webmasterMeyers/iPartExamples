<%@ Control Language="C#" Debug="true" AutoEventWireup="true" CodeFile="demo.ascx.cs" Inherits="DemoNamespace.DemoClass" %>

<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Net" %>
<%@ Import Namespace="System.Net.Http" %>
<%@ Import Namespace="System.Web" %>

<script language="C#" runat="server">

	protected override void OnInit(EventArgs e)
	{
		base.OnInit(e);
	}

</script>

<p>welcome to the next level.</p>
<p><asiweb:StyledLabel ID="ExampleCurrentUser" runat="server"></asiweb:StyledLabel></p>
<p><asiweb:StyledLabel ID="Output" runat="server"></asiweb:StyledLabel></p>