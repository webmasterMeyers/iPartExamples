<script runat="server">
	public string resp = "<p>Please enter some text above.</p>";
	
	void btnSubmit_Click(Object sender, EventArgs e)
	{
		resp = "Why hello " + txtString.Text + ", boy this is useless!";
	}
</script>

<p>What is your Name: <asp:TextBox id="txtString" runat="server" Text="" />
	<asp:Button id="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" /></p>
 
<%= resp %>