using System.IO;
using UnityEngine;
using UnityEditor;


namespace Unity.FLDKT.Editor
{
    static class DefaultShaderIncludes
    {
        [ShaderIncludePath]
        public static string[] GetPaths()
        {
            var paths = new string[1];
            paths[0] = Path.GetFullPath("Packages/com.dotprodukt.unity-fldkt/FLDKT/Shaders/Lib");
            return paths;
        }
    }
}
