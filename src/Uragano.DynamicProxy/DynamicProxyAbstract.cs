﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Uragano.DynamicProxy
{
	public abstract class DynamicProxyAbstract
	{


		protected void Invoke(object[] args, string route)
		{

		}

		protected T Invoke<T>(object[] args, string route)
		{
			return default;
		}

		protected async Task InvokeAsync(object[] args, string route)
		{

		}

		protected async Task<T> InvokeAsync<T>(object[] args, string route)
		{
			return default;
		}
	}
}
