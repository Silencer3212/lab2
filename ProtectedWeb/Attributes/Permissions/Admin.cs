// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using ProtectedWeb.Utils;

namespace ProtectedWeb.Attributes.Permissions
{
    public class Admin : Attribute, IPageFilter
    {
        public void OnPageHandlerExecuting(PageHandlerExecutingContext filterContext)
        {
            if (!UserMethods.HaveAdminRights(filterContext.HttpContext.Request.Cookies["access_token"]))
            {
                filterContext.Result = new ForbidResult();
            }
        }
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {

        }
        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {

        }
    }
}
