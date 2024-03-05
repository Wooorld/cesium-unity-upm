#if UNITY_EDITOR_WIN
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    internal partial class TestGltfModel : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(TestGltfModel managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_TestGltfModel_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_TestGltfModel_DestroyImplementation(this.handle);
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
        public void Dispose()
        {
            
            this.DisposeImplementation();
        }
        public TestGltfModel()
        {
            CreateImplementation();
        }
        public partial CesiumForUnity.CesiumFeatureIdAttribute AddFeatureIdAttribute(ushort[] featureIds, long featureCount)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFeatureIdAttribute cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdAttribute(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(featureIds), featureCount);
                return (CesiumForUnity.CesiumFeatureIdAttribute)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumFeatureIdTexture AddFeatureIdTexture(ushort[] featureIds, long featureCount, Unity.Mathematics.float2[] uvs)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFeatureIdTexture cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdTexture(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(featureIds), featureCount, Reinterop.ObjectHandleUtility.CreateHandle(uvs));
                return (CesiumForUnity.CesiumFeatureIdTexture)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddBooleanPropertyTableProperty(bool[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddBooleanPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddBooleanPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddIntPropertyTableProperty(int[] values, bool normalized)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddIntPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddIntPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), normalized ? (byte)1 : (byte)0);
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddDoublePropertyTableProperty(double[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddDoublePropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddDoublePropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec2PropertyTableProperty(Unity.Mathematics.float2[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec2PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec2PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec3PropertyTableProperty(Unity.Mathematics.float3[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec3PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec3PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec4PropertyTableProperty(Unity.Mathematics.float4[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec4PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec4PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat2PropertyTableProperty(Unity.Mathematics.float2x2[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat2PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat2PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat3PropertyTableProperty(Unity.Mathematics.float3x3[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat3PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat3PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat4PropertyTableProperty(Unity.Mathematics.float4x4[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat4PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat4PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddStringPropertyTableProperty(string[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddStringPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddStringPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddFixedLengthArrayPropertyTableProperty(double[] values, long count)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFixedLengthArrayPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFixedLengthArrayPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), count);
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVariableLengthArrayPropertyTableProperty(double[] values, ushort[] offsets)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVariableLengthArrayPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVariableLengthArrayPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), Reinterop.ObjectHandleUtility.CreateHandle(offsets));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_TestGltfModel_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdAttribute(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr featureIds, long featureCount);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdTexture(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr featureIds, long featureCount, System.IntPtr uvs);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddBooleanPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddIntPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, byte normalized);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddDoublePropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec2PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec3PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec4PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat2PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat3PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat4PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddStringPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFixedLengthArrayPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, long count);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVariableLengthArrayPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, System.IntPtr offsets);
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
    internal partial class TestGltfModel : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(TestGltfModel managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_TestGltfModel_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_TestGltfModel_DestroyImplementation(this.handle);
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
        public void Dispose()
        {
            
            this.DisposeImplementation();
        }
        public TestGltfModel()
        {
            CreateImplementation();
        }
        public partial CesiumForUnity.CesiumFeatureIdAttribute AddFeatureIdAttribute(ushort[] featureIds, long featureCount)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFeatureIdAttribute cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdAttribute(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(featureIds), featureCount);
                return (CesiumForUnity.CesiumFeatureIdAttribute)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumFeatureIdTexture AddFeatureIdTexture(ushort[] featureIds, long featureCount, Unity.Mathematics.float2[] uvs)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFeatureIdTexture cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdTexture(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(featureIds), featureCount, Reinterop.ObjectHandleUtility.CreateHandle(uvs));
                return (CesiumForUnity.CesiumFeatureIdTexture)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddBooleanPropertyTableProperty(bool[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddBooleanPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddBooleanPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddIntPropertyTableProperty(int[] values, bool normalized)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddIntPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddIntPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), normalized ? (byte)1 : (byte)0);
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddDoublePropertyTableProperty(double[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddDoublePropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddDoublePropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec2PropertyTableProperty(Unity.Mathematics.float2[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec2PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec2PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec3PropertyTableProperty(Unity.Mathematics.float3[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec3PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec3PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec4PropertyTableProperty(Unity.Mathematics.float4[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec4PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec4PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat2PropertyTableProperty(Unity.Mathematics.float2x2[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat2PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat2PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat3PropertyTableProperty(Unity.Mathematics.float3x3[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat3PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat3PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat4PropertyTableProperty(Unity.Mathematics.float4x4[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat4PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat4PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddStringPropertyTableProperty(string[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddStringPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddStringPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddFixedLengthArrayPropertyTableProperty(double[] values, long count)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFixedLengthArrayPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFixedLengthArrayPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), count);
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVariableLengthArrayPropertyTableProperty(double[] values, ushort[] offsets)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVariableLengthArrayPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVariableLengthArrayPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), Reinterop.ObjectHandleUtility.CreateHandle(offsets));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_TestGltfModel_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdAttribute(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr featureIds, long featureCount);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdTexture(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr featureIds, long featureCount, System.IntPtr uvs);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddBooleanPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddIntPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, byte normalized);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddDoublePropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec2PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec3PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec4PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat2PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat3PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat4PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddStringPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFixedLengthArrayPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, long count);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVariableLengthArrayPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, System.IntPtr offsets);
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
    internal partial class TestGltfModel : System.IDisposable
    {
        internal class ImplementationHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            public ImplementationHandle(TestGltfModel managed) : base(true)
            {
                SetHandle(DotNet_CesiumForUnity_TestGltfModel_CreateImplementation(Reinterop.ObjectHandleUtility.CreateHandle(managed)));
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            protected override bool ReleaseHandle()
            {
                DotNet_CesiumForUnity_TestGltfModel_DestroyImplementation(this.handle);
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
        public void Dispose()
        {
            
            this.DisposeImplementation();
        }
        public TestGltfModel()
        {
            CreateImplementation();
        }
        public partial CesiumForUnity.CesiumFeatureIdAttribute AddFeatureIdAttribute(ushort[] featureIds, long featureCount)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFeatureIdAttribute cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdAttribute(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(featureIds), featureCount);
                return (CesiumForUnity.CesiumFeatureIdAttribute)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumFeatureIdTexture AddFeatureIdTexture(ushort[] featureIds, long featureCount, Unity.Mathematics.float2[] uvs)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFeatureIdTexture cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdTexture(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(featureIds), featureCount, Reinterop.ObjectHandleUtility.CreateHandle(uvs));
                return (CesiumForUnity.CesiumFeatureIdTexture)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddBooleanPropertyTableProperty(bool[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddBooleanPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddBooleanPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddIntPropertyTableProperty(int[] values, bool normalized)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddIntPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddIntPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), normalized ? (byte)1 : (byte)0);
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddDoublePropertyTableProperty(double[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddDoublePropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddDoublePropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec2PropertyTableProperty(Unity.Mathematics.float2[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec2PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec2PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec3PropertyTableProperty(Unity.Mathematics.float3[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec3PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec3PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVec4PropertyTableProperty(Unity.Mathematics.float4[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVec4PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVec4PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat2PropertyTableProperty(Unity.Mathematics.float2x2[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat2PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat2PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat3PropertyTableProperty(Unity.Mathematics.float3x3[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat3PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat3PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddMat4PropertyTableProperty(Unity.Mathematics.float4x4[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddMat4PropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddMat4PropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddStringPropertyTableProperty(string[] values)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddStringPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddStringPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddFixedLengthArrayPropertyTableProperty(double[] values, long count)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddFixedLengthArrayPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddFixedLengthArrayPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), count);
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }
        public partial CesiumForUnity.CesiumPropertyTableProperty AddVariableLengthArrayPropertyTableProperty(double[] values, ushort[] offsets)
        {
            unsafe
            {
                if (this._implementation == null || this._implementation.IsInvalid)
                    throw new NotImplementedException("The native implementation is missing so AddVariableLengthArrayPropertyTableProperty cannot be invoked. This may be caused by a missing call to CreateImplementation in one of your constructors, or it may be that the entire native implementation shared library is missing or out of date.");
                var result = DotNet_CesiumForUnity_TestGltfModel_AddVariableLengthArrayPropertyTableProperty(Reinterop.ObjectHandleUtility.CreateHandle(this), _implementation, Reinterop.ObjectHandleUtility.CreateHandle(values), Reinterop.ObjectHandleUtility.CreateHandle(offsets));
                return (CesiumForUnity.CesiumPropertyTableProperty)Reinterop.ObjectHandleUtility.GetObjectAndFreeHandle(result)!;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_CreateImplementation(System.IntPtr thiz);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static extern void DotNet_CesiumForUnity_TestGltfModel_DestroyImplementation(System.IntPtr implementation);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdAttribute(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr featureIds, long featureCount);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFeatureIdTexture(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr featureIds, long featureCount, System.IntPtr uvs);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddBooleanPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddIntPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, byte normalized);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddDoublePropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec2PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec3PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVec4PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat2PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat3PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddMat4PropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddStringPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddFixedLengthArrayPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, long count);
        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern System.IntPtr DotNet_CesiumForUnity_TestGltfModel_AddVariableLengthArrayPropertyTableProperty(System.IntPtr thiz, CesiumForUnity.TestGltfModel.ImplementationHandle implementation, System.IntPtr values, System.IntPtr offsets);
    }
}
#endif
