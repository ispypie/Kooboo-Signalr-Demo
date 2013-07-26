#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kooboo.CMS.Sites.Extension.ModuleArea;
using Kooboo.ComponentModel;

namespace ChatModule
{
	public class AdminControllerBase : ModuleAreaControllerBase
	{
		static AdminControllerBase()
		{
			TypeDescriptorHelper.RegisterMetadataType(typeof(ModuleSettings), typeof(ChatModule.Models.ModuleSettings_Metadata));
		}
	}
}
