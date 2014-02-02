using System;

using Java.Interop;

namespace Java.InteropTests
{
	public class ExportTest : JavaObject
	{
		public ExportTest (JniReferenceSafeHandle handle, JniHandleOwnership transfer)
			: base (handle, transfer)
		{
		}

		public bool HelloCalled;

		[Export ("action", Signature="()V")]
		public void InstanceAction ()
		{
			HelloCalled = true;
		}

		public static bool StaticHelloCalled;

		[Export ("staticAction", Signature="()V")]
		public static void StaticAction ()
		{
			StaticHelloCalled = true;
		}

		[Export ("actionInt32String", Signature = "(ILjava/lang/String;)V")]
		public void ActionInt32String (int i, string v)
		{
		}

		[Export ("funcInt64", Signature = "()J")]
		public long FuncInt64 ()
		{
			return 42;
		}
	}
}
