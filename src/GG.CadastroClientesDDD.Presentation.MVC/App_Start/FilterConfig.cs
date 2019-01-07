using System.Web;
using System.Web.Mvc;

namespace GG.CadastroClientesDDD.Presentation.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
