using System.Collections.Generic;
using UnityEditor;

namespace SyskenTLib.STSceneOpenShortcutEditor
{
    public class STSceneListManager
    {
        public static void  AddHideScene(SceneAsset hideScene)
        {
            

            if (hideScene != null)
            {
                STSceneListConfig config = STConfigManager.GetSceneListConfig(); 
                config.hiddenSceneList.Add(hideScene);
                EditorUtility.SetDirty(config);
                AssetDatabase.SaveAssets();
            }
            
        }
    }
}