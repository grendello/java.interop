// This really should be auto-generated, but isn't for test purposes.
using System;

using Java.Interop;

using NUnit.Framework;

namespace Java.InteropTests
{
	[JniTypeInfo (TestType.JniTypeName)]
	public partial class TestType : JavaObject
	{
		internal    const    string         JniTypeName = "com/xamarin/interop/TestType";
		static      readonly JniPeerMembers _members    = new JniPeerMembers (JniTypeName, typeof (TestType));

		static TestType ()
		{
			_members.JniPeerType.RegisterNativeMethods (
					new JniNativeMethodRegistration ("equalsThis", "(Ljava/lang/Object;)Z", GetEqualsThisHandler ()),
					new JniNativeMethodRegistration ("getInt32Value", "()I", GetInt32ValueHandler ()),
					new JniNativeMethodRegistration ("getStringValue", "(I)Ljava/lang/String;", GetStringValueHandler ()));
		}

		public override JniPeerMembers JniPeerMembers {
			get {
				return _members;
			}
		}

		public TestType ()
		{
		}

		public TestType (JniReferenceSafeHandle handle, JniHandleOwnership transfer)
			: base (handle, transfer)
		{
		}

		public void RunTests ()
		{
			_members.InstanceMethods.CallVoidMethod ("runTests\u0000()V", this);
		}

		public int UpdateInt32Array (int[] value)
		{
			return _members.InstanceMethods.CallInt32Method ("updateInt32Array\u0000([I)I", this, value);
		}

		public int UpdateInt32ArrayArray (int[][] value)
		{
			return _members.InstanceMethods.CallInt32Method ("updateInt32ArrayArray\u0000([[I)I", this, value);
		}

		public int UpdateInt32ArrayArrayArray (int[][][] value)
		{
			return _members.InstanceMethods.CallInt32Method ("updateInt32ArrayArrayArray\u0000([[[I)I", this, value);
		}

		public int Identity (int value)
		{
			return _members.InstanceMethods.CallInt32Method ("identity\u0000(I)I", this, value);
		}

		static Delegate GetEqualsThisHandler ()
		{
			Func<IntPtr, IntPtr, IntPtr, bool> h = (jnienv, n_self, n_value) => {
				JniEnvironment.CheckCurrent (jnienv);

				var jvm     = JniEnvironment.Current.JavaVM;
				var self    = jvm.GetObject<TestType>(n_self);
				var value   = jvm.GetObject (n_value);

				try {
					return self.EqualsThis (value);
				} finally {
					self.DisposeUnlessRegistered ();
					value.DisposeUnlessRegistered ();
				}
			};
			return h;
		}

		static Delegate GetInt32ValueHandler ()
		{
			Func<IntPtr, IntPtr, int> h = (jnienv, n_self) => {
				JniEnvironment.CheckCurrent (jnienv);

				var self = JniEnvironment.Current.JavaVM.GetObject<TestType>(n_self);
				try {
					return self.GetInt32Value ();
				} finally {
					self.DisposeUnlessRegistered ();
				}
			};
			return h;
		}

		static Delegate GetStringValueHandler ()
		{
			Func<IntPtr, IntPtr, int, IntPtr> h = (jnienv, n_self, value) => {
				JniEnvironment.CheckCurrent (jnienv);
				var self = JniEnvironment.Current.JavaVM.GetObject<TestType>(n_self);
				try {
					var s = self.GetStringValue (value);
					using (var r = JniEnvironment.Strings.NewString (s))
						return JniEnvironment.Handles.NewReturnToJniRef (r);
				} finally {
					self.DisposeUnlessRegistered ();
				}
			};
			return h;
		}

		public bool EqualsThis (IJavaObject value)
		{
			Assert.IsNotNull (value);
			Assert.AreNotSame (this, value);
			Assert.IsTrue (JniEnvironment.Types.IsSameObject (SafeHandle, value.SafeHandle));
			return value != null && !object.ReferenceEquals (value, this) &&
				JniEnvironment.Types.IsSameObject (SafeHandle, value.SafeHandle);
		}

		public int GetInt32Value ()
		{
			return 42;
		}

		public string GetStringValue (int value)
		{
			return value.ToString ();
		}
	}
}
