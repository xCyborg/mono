// 
// System.Web.Services.Protocols.SoapHeaderAttribute.cs
//
// Author:
//   Tim Coleman (tim@timcoleman.com)
//
// Copyright (C) Tim Coleman, 2002
//

namespace System.Web.Services.Protocols {
	[AttributeUsage (AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public sealed class SoapHeaderAttribute : Attribute {

		#region Fields

		SoapHeaderDirection direction;
		string memberName;
		bool required;

		#endregion // Fields

		#region Constructors

		public SoapHeaderAttribute (string memberName) 
		{
			direction = SoapHeaderDirection.In;
			this.memberName = memberName;
			required = true;
		}

		#endregion // Constructors

		#region Properties

		public SoapHeaderDirection Direction {
			get { return direction; }
			set { direction = value; }
		}

		public string MemberName {	
			get { return memberName; }
			set { memberName = value; }
		}

#if NET_1_1
               [Obsolete ("This property will be removed from a future"
                       + " version. The presence of a particular header"
                       + " in a SOAP message is no longer enforced", false)]
#endif
		public bool Required {
			get { return required; }
			set { required = value; }
		}

		#endregion // Properties
	}
}
