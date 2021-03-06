﻿using WebMarkupMin.AspNet.Common;
using WebMarkupMin.AspNet4.Common;

namespace WebMarkupMin.AspNet4.HttpModules
{
	/// <summary>
	/// HTTP module for XHTML minification
	/// </summary>
	public sealed class XhtmlMinificationModule : MarkupMinificationModuleBase
	{
		/// <summary>
		/// Constructs a instance of HTTP module for XHTML minification
		/// </summary>
		public XhtmlMinificationModule()
			: this(WebMarkupMinConfiguration.Instance, null)
		{ }

		/// <summary>
		/// Constructs a instance of HTTP module for XHTML minification
		/// </summary>
		/// <param name="configuration">WebMarkupMin configuration</param>
		/// <param name="minificationManager">XHTML minification manager</param>
		public XhtmlMinificationModule(
			WebMarkupMinConfiguration configuration,
			IXhtmlMinificationManager minificationManager)
			: base(configuration, minificationManager)
		{ }


		/// <summary>
		/// Gets a instance of default XHTML minification manager
		/// </summary>
		/// <returns>Instance of default XHTML minification manager</returns>
		protected override IMarkupMinificationManager GetDefaultMinificationManager()
		{
			return XhtmlMinificationManager.Current;
		}
	}
}