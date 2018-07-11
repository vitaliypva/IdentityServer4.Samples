// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;
using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.Services;
using IdentityServerWithAspIdAndEF;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using IdentityServerWithAspIdAndEF.Data;
using Microsoft.AspNetCore.Identity;

namespace IdentityServer4.Quickstart.UI
{
    [SecurityHeaders]
    public class HomeController : Controller
    {
        private readonly IIdentityServerInteractionService _interaction;
       

        public HomeController(IIdentityServerInteractionService interaction, ApplicationDbContext appContext)
        {
            _interaction = interaction;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Shows the error page
        /// </summary>
        public async Task<IActionResult> Error(string errorId)
        {
            var vm = new ErrorViewModel();

            // retrieve error details from identityserver
            var message = await _interaction.GetErrorContextAsync(errorId);
            if (message != null)
            {
                vm.Error = message;
            }

            return View("Error", vm);
        }
    }
}