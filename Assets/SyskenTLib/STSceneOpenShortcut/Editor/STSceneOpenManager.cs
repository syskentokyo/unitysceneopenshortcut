using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace SyskenTLib.STSceneOpenShortcutEditor
{
    public class STSceneOpenManager
    {
        public static void  OpenScene(SceneAsset baseScene, List<SceneAsset> addSceneList)
        {
            if(EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo() == false){
                //シーン編集中なら処理しない
                Debug.LogWarning("現在のシーンを編集中です。シーンの保存などをおこなってください");
                return;
            }
            
            //
            // シーン読み込み
            //

            if (baseScene != null)
            {
                Debug.Log("シーン読み込み："+AssetDatabase.GetAssetPath(baseScene));
                EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(baseScene), OpenSceneMode.Single);
            }

            addSceneList.ForEach(addScene =>
            {
                EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(addScene), OpenSceneMode.Additive);
            });
        }
    }
}