using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace SyskenTLib.STSceneOpenShortcutEditor
{
    public class STConfigManager
    {
        

        public static STSceneOpenExConfig GetSceneOpenExConfig()
        {

            STSceneOpenExConfig rootConfig= AssetDatabase.FindAssets("t:STSceneOpenExConfig")
                .ToList()
                .Select(nextGUID => AssetDatabase.GUIDToAssetPath(nextGUID))
                .ToList()
                .Select(configPath => AssetDatabase.LoadAssetAtPath<STSceneOpenExConfig>(configPath))
                .FirstOrDefault();

            return rootConfig;
        }
        
        
        
        public static STSceneListConfig GetSceneListConfig()
        {

            STSceneListConfig rootConfig= AssetDatabase.FindAssets("t:STSceneListConfig")
                .ToList()
                .Select(nextGUID => AssetDatabase.GUIDToAssetPath(nextGUID))
                .ToList()
                .Select(configPath => AssetDatabase.LoadAssetAtPath<STSceneListConfig>(configPath))
                .FirstOrDefault();

            return rootConfig;
        }
     

    }
}