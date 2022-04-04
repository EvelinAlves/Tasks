<%@ Application Language="C#" %>
<%@ Import Namespace="Tasks" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.Data.Entity" %>


<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);

        Database.SetInitializer(new TarefaDatabaseInitializer());
    }

</script>
