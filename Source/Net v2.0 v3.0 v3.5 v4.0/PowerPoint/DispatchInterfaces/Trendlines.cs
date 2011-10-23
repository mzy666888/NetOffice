//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Trendlines SupportByLibrary PowerPoint, 14
	///</summary>
	[SupportByLibrary("PowerPoint", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Trendlines : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Trendlines);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Trendlines(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		/// <param name="Type">NetOffice.PowerPointApi.Enums.XlTrendlineType Type</param>
		/// <param name="Order">optional object Order</param>
		/// <param name="Period">optional object Period</param>
		/// <param name="Forward">optional object Forward</param>
		/// <param name="Backward">optional object Backward</param>
		/// <param name="Intercept">optional object Intercept</param>
		/// <param name="DisplayEquation">optional object DisplayEquation</param>
		/// <param name="DisplayRSquared">optional object DisplayRSquared</param>
		/// <param name="Name">optional object Name</param>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Trendline Add(NetOffice.PowerPointApi.Enums.XlTrendlineType type, object order, object period, object forward, object backward, object intercept, object displayEquation, object displayRSquared, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, order, period, forward, backward, intercept, displayEquation, displayRSquared, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Trendline.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		/// <param name="Type">NetOffice.PowerPointApi.Enums.XlTrendlineType Type</param>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Trendline Add(NetOffice.PowerPointApi.Enums.XlTrendlineType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Trendline.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibrary("PowerPoint", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.Trendline this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Trendline.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Trendline;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Trendline _Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
			NetOffice.PowerPointApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Trendline.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Trendline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Trendline _Default()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
			NetOffice.PowerPointApi.Trendline newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Trendline.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Trendline;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("PowerPoint", 14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}