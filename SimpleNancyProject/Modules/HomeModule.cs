using Nancy;

namespace SimpleNancyProject.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello from Nancy");
        }
    }
}