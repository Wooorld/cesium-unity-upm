#if UNITY_EDITOR_WIN
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumFeatureIdAttribute : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeatureIdAttribute managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeatureIdAttribute_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeatureIdAttribute_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public override void Dispose()
        {
            base.Dispose();
            this.DisposeImplementation();
        }
        public override partial long GetFeatureIdForVertex(long vertexIndex)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForVertex cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdAttribute_GetFeatureIdForVertex(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, vertexIndex);
                return result;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeatureIdAttribute_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeatureIdAttribute_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdAttribute_GetFeatureIdForVertex(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdAttribute.ImplementationHandle implementation, long vertexIndex);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_WIN
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumFeatureIdAttribute : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeatureIdAttribute managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeatureIdAttribute_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeatureIdAttribute_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public override void Dispose()
        {
            base.Dispose();
            this.DisposeImplementation();
        }
        public override partial long GetFeatureIdForVertex(long vertexIndex)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForVertex cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdAttribute_GetFeatureIdForVertex(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, vertexIndex);
                return result;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeatureIdAttribute_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeatureIdAttribute_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdAttribute_GetFeatureIdForVertex(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdAttribute.ImplementationHandle implementation, long vertexIndex);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_ANDROID
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumFeatureIdAttribute : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeatureIdAttribute managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeatureIdAttribute_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeatureIdAttribute_DestroyImplementation(this.handle);
                return true;
            }
        }

        [System.NonSerialized]
        private ImplementationHandle _implementation = null;

        internal ImplementationHandle NativeImplementation
        {
            get { return _implementation; }
        }

        private void CreateImplementation()
        {
            Reinterop.ReinteropInitializer.Initialize();
            System.Diagnostics.Debug.Assert(this._implementation == null, "Implementation is already created. Be sure to call CreateImplementation only once.");
            this._implementation = new ImplementationHandle(this);
        }
        protected void DisposeImplementation()
        {
            if (this._implementation != null && !this._implementation.IsInvalid)
                this._implementation.Dispose();
            this._implementation = null;
        }
        public override void Dispose()
        {
            base.Dispose();
            this.DisposeImplementation();
        }
        public override partial long GetFeatureIdForVertex(long vertexIndex)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForVertex cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdAttribute_GetFeatureIdForVertex(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, vertexIndex);
                return result;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeatureIdAttribute_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeatureIdAttribute_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdAttribute_GetFeatureIdForVertex(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdAttribute.ImplementationHandle implementation, long vertexIndex);
    }
}
#endif
