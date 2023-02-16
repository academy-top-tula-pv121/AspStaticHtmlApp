namespace AspStaticHtmlApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();
                //new WebApplicationOptions { WebRootPath = "html" });
            var app = builder.Build();

            // index.html
            // index.htm
            // default.html
            // default.htm
            DefaultFilesOptions options = new();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("about.html");

            app.UseDefaultFiles(options);

            app.UseStaticFiles();

            //app.Run(async (context) =>
            //{
            //    //context.Response.ContentType = "text/html; charset=utf-8";
            //    await context.Response.SendFileAsync("index.html");
            //});
                

            app.Run();
        }
    }

    /*
    ContentRoot - 
    WebRoot - wwwroot
    ContentRoot/WebRoot
    */
}