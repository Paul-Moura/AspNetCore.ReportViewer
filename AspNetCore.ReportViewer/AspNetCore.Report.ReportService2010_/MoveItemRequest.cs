﻿
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "MoveItem", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class MoveItemRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string ItemPath;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string Target;

		public MoveItemRequest()
		{
		}

		public MoveItemRequest(TrustedUserHeader TrustedUserHeader, string ItemPath, string Target)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.ItemPath = ItemPath;
			this.Target = Target;
		}
	}
}