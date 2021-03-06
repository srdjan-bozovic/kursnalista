﻿using System;
using KursnaLista.Mobile.Common;
using Xamarin.Forms;

namespace KursnaLista.Mobile
{
	public class App
	{
		private static ViewModelLocator _locator;

		public static ViewModelLocator Locator
		{
			get
			{
				return _locator ?? (_locator = new ViewModelLocator());
			}
		}

		public static Page GetMainPage ()
		{	
			return new NavigationPage(new MainPageView());
		}
	}
}

