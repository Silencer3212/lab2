﻿// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using Microsoft.AspNetCore.Mvc.Filters;
using ProtectedWeb.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ProtectedWeb.Attributes.Permissions
{
    public class Moder : Attribute, IPageFilter
    {
        public void OnPageHandlerExecuting(PageHandlerExecutingContext filterContext)
        {
            if (!UserMethods.HaveModerRights(filterContext.HttpContext.Request.Cookies["access_token"]))
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
