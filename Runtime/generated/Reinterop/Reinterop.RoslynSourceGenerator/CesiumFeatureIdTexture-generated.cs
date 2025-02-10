#if UNITY_EDITOR_WIN
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class CesiumFeatureIdTexture : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeatureIdTexture managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeatureIdTexture_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeatureIdTexture_DestroyImplementation(this.handle);
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
        public partial long GetFeatureIdForUV(UnityEngine.Vector2 uv)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForUV cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForUV(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, &uv);
                return result;
            }
        }
        public override partial long GetFeatureIdForVertex(long vertexIndex)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForVertex cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForVertex(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, vertexIndex);
                return result;
            }
        }
        public override partial long GetFeatureIdFromRaycastHit(UnityEngine.RaycastHit hitInfo)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdFromRaycastHit cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdFromRaycastHit(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, &hitInfo);
                return result;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeatureIdTexture_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeatureIdTexture_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForUV(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, UnityEngine.Vector2* uv);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForVertex(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, long vertexIndex);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdFromRaycastHit(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, UnityEngine.RaycastHit* hitInfo);
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
    public partial class CesiumFeatureIdTexture : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeatureIdTexture managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeatureIdTexture_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeatureIdTexture_DestroyImplementation(this.handle);
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
        public partial long GetFeatureIdForUV(UnityEngine.Vector2 uv)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForUV cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForUV(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, &uv);
                return result;
            }
        }
        public override partial long GetFeatureIdForVertex(long vertexIndex)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForVertex cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForVertex(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, vertexIndex);
                return result;
            }
        }
        public override partial long GetFeatureIdFromRaycastHit(UnityEngine.RaycastHit hitInfo)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdFromRaycastHit cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdFromRaycastHit(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, &hitInfo);
                return result;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeatureIdTexture_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeatureIdTexture_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForUV(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, UnityEngine.Vector2* uv);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForVertex(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, long vertexIndex);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdFromRaycastHit(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, UnityEngine.RaycastHit* hitInfo);
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
    public partial class CesiumFeatureIdTexture : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(CesiumFeatureIdTexture managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_CesiumFeatureIdTexture_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_CesiumFeatureIdTexture_DestroyImplementation(this.handle);
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
        public partial long GetFeatureIdForUV(UnityEngine.Vector2 uv)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForUV cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForUV(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, &uv);
                return result;
            }
        }
        public override partial long GetFeatureIdForVertex(long vertexIndex)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdForVertex cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForVertex(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, vertexIndex);
                return result;
            }
        }
        public override partial long GetFeatureIdFromRaycastHit(UnityEngine.RaycastHit hitInfo)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so GetFeatureIdFromRaycastHit cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdFromRaycastHit(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, &hitInfo);
                return result;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_CesiumFeatureIdTexture_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_CesiumFeatureIdTexture_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForUV(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, UnityEngine.Vector2* uv);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdForVertex(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, long vertexIndex);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern long DotNet_CesiumForUnity_CesiumFeatureIdTexture_GetFeatureIdFromRaycastHit(System.IntPtr thiz, CesiumForUnity.CesiumFeatureIdTexture.ImplementationHandle implementation, UnityEngine.RaycastHit* hitInfo);
    }
}
#endif
