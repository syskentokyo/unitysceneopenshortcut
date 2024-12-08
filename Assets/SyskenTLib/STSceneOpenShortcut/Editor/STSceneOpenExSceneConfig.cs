using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SyskenTLib.STSceneOpenShortcutEditor
{
    public class STSceneOpenExSceneConfig : ScriptableObject
    {
        [Header("ベースシーン")]
        [SerializeField] 
        private SceneAsset baseScene;
        public SceneAsset GetBaseScene=> baseScene;

        [Header("追加読み込みシーン")] [SerializeField] private List<SceneAsset> addSceneList;
        public List<SceneAsset> GetAddSceneList => addSceneList;

    }
}