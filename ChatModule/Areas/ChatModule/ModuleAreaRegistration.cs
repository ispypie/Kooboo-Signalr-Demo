﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion

using System.Web.Mvc;
using System.IO;
using Kooboo;
using Kooboo.Web.Mvc;

namespace ChatModule.Areas.ChatModule
{
	public class ModuleAreaRegistration : AreaRegistration
	{
		public const string ModuleName = "ChatModule";
		public override string AreaName
		{
			get
			{
				return ModuleName;
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
			   ModuleName + "_default",
				ModuleName + "/{controller}/{action}",
				new { controller = "Admin", action = "Index" }
				, null
				, new[] { "ChatModule.Controllers", "ChatModule.Areas.ChatModule.Controllers", "Kooboo.Web.Mvc", "Kooboo.Web.Mvc.WebResourceLoader" }
			);

			var menuFile = AreaHelpers.CombineAreaFilePhysicalPath(AreaName, "CMSMenu.config");
			if (File.Exists(menuFile))
			{
				Kooboo.Web.Mvc.Menu.MenuFactory.RegisterAreaMenu(AreaName, menuFile);
			}
			var resourceFile = Path.Combine(Settings.BaseDirectory, "Areas", AreaName, "WebResources.config");
			if (File.Exists(resourceFile))
			{
				Kooboo.Web.Mvc.WebResourceLoader.ConfigurationManager.RegisterSection(AreaName, resourceFile);
			}
		}
	}
}
