#if UNITY_EDITOR_WIN
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTile
    {
        private static partial UnityEngine.Bounds getBounds(System.IntPtr pTile, System.IntPtr pTileEllipsoid, Unity.Mathematics.double4x4 ecefToLocalMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new UnityEngine.Bounds();
                DotNet_CesiumForUnity_Cesium3DTile_getBounds(pTile, pTileEllipsoid, &ecefToLocalMatrix, &returnValue);
                return returnValue;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTile_getBounds(System.IntPtr pTile, System.IntPtr pTileEllipsoid, Unity.Mathematics.double4x4* ecefToLocalMatrix, UnityEngine.Bounds* pReturnValue);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_STANDALONE_WIN
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTile
    {
        private static partial UnityEngine.Bounds getBounds(System.IntPtr pTile, System.IntPtr pTileEllipsoid, Unity.Mathematics.double4x4 ecefToLocalMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new UnityEngine.Bounds();
                DotNet_CesiumForUnity_Cesium3DTile_getBounds(pTile, pTileEllipsoid, &ecefToLocalMatrix, &returnValue);
                return returnValue;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTile_getBounds(System.IntPtr pTile, System.IntPtr pTileEllipsoid, Unity.Mathematics.double4x4* ecefToLocalMatrix, UnityEngine.Bounds* pReturnValue);
    }
}
#endif
#if !UNITY_EDITOR && UNITY_ANDROID
using System;
using System.Runtime.InteropServices;

namespace CesiumForUnity
{
    public partial class Cesium3DTile
    {
        private static partial UnityEngine.Bounds getBounds(System.IntPtr pTile, System.IntPtr pTileEllipsoid, Unity.Mathematics.double4x4 ecefToLocalMatrix)
        {
            unsafe
            {
                Reinterop.ReinteropInitializer.Initialize();
                var returnValue = new UnityEngine.Bounds();
                DotNet_CesiumForUnity_Cesium3DTile_getBounds(pTile, pTileEllipsoid, &ecefToLocalMatrix, &returnValue);
                return returnValue;
            }
        }

        [DllImport("CesiumForUnityNative-Runtime", CallingConvention=CallingConvention.Cdecl)]
        private static unsafe extern void DotNet_CesiumForUnity_Cesium3DTile_getBounds(System.IntPtr pTile, System.IntPtr pTileEllipsoid, Unity.Mathematics.double4x4* ecefToLocalMatrix, UnityEngine.Bounds* pReturnValue);
    }
}
#endif
