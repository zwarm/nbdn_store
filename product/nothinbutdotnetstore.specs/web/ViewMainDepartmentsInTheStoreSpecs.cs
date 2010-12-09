 using System.Web.UI.WebControls;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.web;
 using nothinbutdotnetstore.web.application;
 using nothinbutdotnetstore.web.infrastructure;

namespace nothinbutdotnetstore.specs.web
{   
    public class ViewMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<ApplicationCommand,
                                            ViewMainDepartmentsInTheStore>
        {
        
        }

        [Subject(typeof(ViewMainDepartmentsInTheStore))]
        public class when_viewing_main_departments : concern
        {

            Establish c = () =>
            {
                resquest = an<Request>();
                response = an<Response>();
                application_command = the_dependency<ViewRenderer>();
            };

            Because b = () =>
                sut.process(request);

            It should_delegate_the_view_rendering_to_the_view_render = () =>
                view_renderer.received(x => x.Render());

            static Response response;
            static Request request;
            static ViewRenderer view_renderer;  
        }
    }
}
