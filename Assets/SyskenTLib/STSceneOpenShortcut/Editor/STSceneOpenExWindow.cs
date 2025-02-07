using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SyskenTLib.STSceneOpenShortcutEditor
{
    public class STSceneOpenExWindow : EditorWindow
    {
        private static  List<SceneAsset> _sceneList = new List<SceneAsset>();
        private static Vector2 _currentMainVerticalScrollPosition = Vector2.zero;
        private static Vector2 _currentMainHorizonScrollPosition = Vector2.zero;
        
        
        
        [MenuItem("SyskenTLib/STSceneOpenShortcut",priority = 200)]
        private static void OpenBase1()
        {

        }
        [MenuItem("SyskenTLib/STSceneOpenShortcut/SceneList",priority = 1)]
        private static void OpenSceneList()
        {
            var window = GetWindow<STSceneOpenExWindow>("Scene Open Ex");
        }
        
        [MenuItem("SyskenTLib/STSceneOpenShortcut/SelectRootConfig",priority = 100)]
        private static void SelectRootConfig()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            if (rootConfig != null)
            {
                
                Selection.activeObject = rootConfig;
            }
        }
        
        // [MenuItem("File/OpenScene",priority = 570)]
        // private static void OpenScene()
        // {
        //     List<SceneAsset> _sceneList = SearchAllScene();
        //     _sceneList.ForEach(scene =>
        //     {
        //         Debug.Log(AssetDatabase.GetAssetPath(scene));   
        //     });
        // }
        
        
        private void OnGUI()
        {
            using (new GUILayout.HorizontalScope())
            {
                if (GUILayout.Button("UpdateList", GUILayout.Width(100)))
                {
                    _sceneList = SearchAllScene();
                }

                GUILayout.Label("シーンの一覧を取得します");
            }
            
            using (new GUILayout.HorizontalScope())
            {
                if (GUILayout.Button("Select Config", GUILayout.Width(100)))
                {
                    STSceneListConfig config = STConfigManager.GetSceneListConfig(); 
                    EditorGUIUtility.PingObject(config);
                }

                GUILayout.Label("非表示のシーンの一覧を取得します");
            }

            using (new GUILayout.VerticalScope())
            {
                using (GUILayout.ScrollViewScope scrollView = new GUILayout.ScrollViewScope(
                           _currentMainVerticalScrollPosition, GUILayout.Width(1100)))
                {
                    _sceneList.ForEach(scene =>
                    {
                        _currentMainVerticalScrollPosition = scrollView.scrollPosition;
                        using (new GUILayout.HorizontalScope())
                        {
                            EditorGUILayout.ObjectField(scene, typeof(SceneAsset), false, GUILayout.Width(200));

                            if (GUILayout.Button("Open", GUILayout.Width(100)))
                            {
                                STSceneOpenManager.OpenScene(scene, new List<SceneAsset>());
                            }

                            if (GUILayout.Button("Add", GUILayout.Width(100)))
                            {
                                STSceneOpenManager.OpenScene(null, new List<SceneAsset>() { scene });
                            }
                            
                            GUILayout.Space(10);
 
                            if (GUILayout.Button("Hide", GUILayout.Width(100)))
                            {
                                STSceneListManager.AddHideScene(scene);
                                _sceneList = SearchAllScene();
                            }

                        }

                    });
                }
            }
        }


        #region 内部

        

        private static  List<SceneAsset> SearchAllScene()
        {
            STSceneListConfig config = STConfigManager.GetSceneListConfig();
            List<string> hideScenePathList =
                config
                    .hiddenSceneList
                    .Select(hideScene => AssetDatabase.GetAssetPath(hideScene))
                    .ToList();
            
            List<SceneAsset> sceneAssetList = AssetDatabase.FindAssets("t:SceneAsset")
                .ToList()
                .Select(nextGUID => AssetDatabase.GUIDToAssetPath(nextGUID))
                .ToList()
                .Where(path => hideScenePathList.Contains(path) == false)
                .Where(path => path.StartsWith("Assets/"))//Packages/のシーンを対象としないためのフィルタ
                .OrderBy(path => path)// パスの順番を整理
                .Select(sceneAsset => AssetDatabase.LoadAssetAtPath<SceneAsset>(sceneAsset))
                .ToList();
            

            return sceneAssetList;
        }
        #endregion

    }
}