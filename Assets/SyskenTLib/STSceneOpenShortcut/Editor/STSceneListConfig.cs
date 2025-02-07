using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SyskenTLib.STSceneOpenShortcutEditor
{

    public class STSceneListConfig : ScriptableObject
    {
        [Header("非表示シーン")] [SerializeField] public List<SceneAsset> hiddenSceneList;
    }
}