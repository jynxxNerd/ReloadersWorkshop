﻿//============================================================================*
// NativeMethods.cs
//
// Copyright © 2013-2014, Kevin S. Beebe
// All Rights Reserved
//============================================================================*

//============================================================================*
// .Net Using Statements
//============================================================================*

using System;
using System.Runtime.InteropServices;
using System.ComponentModel;

//============================================================================*
// Namespace
//============================================================================*

namespace ReloadersWorkShopLauncher
	{
	//============================================================================*
	// NativeMethods Class
	//============================================================================*

	internal static class NativeMethods
		{
		//============================================================================*
		// SetForegroundWindow()
		//============================================================================*

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		//============================================================================*
		// ShowWindowAsync()
		//============================================================================*

		[DllImport("user32.dll")]
		public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
		}
	}
