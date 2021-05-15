using UnityEngine;
using UnityEditor;
using System.IO;

public class ShaderEditorHelper
{
    [MenuItem("Assets/Create/Shader/Custom Function (HLSL)")]
    static void CreateCustomFunction()
    {
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile("Assets/Editor/CFTemplate.hlsl", "New Function.hlsl");
    }
}
