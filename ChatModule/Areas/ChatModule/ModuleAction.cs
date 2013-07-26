﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using Kooboo.CMS.Sites.Extension.ModuleArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatModule.Areas.ChatModule
{
	[Kooboo.CMS.Common.Runtime.Dependency.Dependency(typeof(IModuleAction), Key = SampleAreaRegistration.ModuleName)]
	public class ModuleAction : IModuleAction
	{
		public void OnExcluded(Kooboo.CMS.Sites.Models.Site site)
		{
			// Add the logic here when the module was excluded from the site.
		}

		public void OnIncluded(Kooboo.CMS.Sites.Models.Site site)
		{
			// Add the logic here when the module was included to the site.
		}
	}
}
