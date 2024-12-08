using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SyskenTLib.STSceneOpenShortcutEditor
{
    public class STSceneOpenShortCutMenuManager
    {
        
        [MenuItem("File/OpenScene:Splash1",priority = 500)]
        private static void OpenSceneSplash1()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetSplashSceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
            
        }
        [MenuItem("File/OpenScene:Main1",priority = 511)]
        private static void OpenSceneMain1()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetMain1SceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
        }
        [MenuItem("File/OpenScene:Main2",priority = 512)]
        private static void OpenSceneMain2()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetMain2SceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
        }
        [MenuItem("File/OpenScene:Main3",priority = 513)]
        private static void OpenSceneMain3()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetMain3SceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
        }
        
        [MenuItem("File/OpenScene:Custom1",priority = 551)]
        private static void OpenSceneCustom1()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetCustom1SceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
        }
        [MenuItem("File/OpenScene:Custom2",priority = 552)]
        private static void OpenSceneCustom2()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetCustom2SceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
        }
        [MenuItem("File/OpenScene:Custom3",priority = 553)]
        private static void OpenSceneCustom3()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetCustom3SceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
        }
        [MenuItem("File/OpenScene:Custom4",priority = 554)]
        private static void OpenSceneCustom4()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetCustom4SceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
        }
        [MenuItem("File/OpenScene:Custom5",priority = 555)]
        private static void OpenSceneCustom5()
        {
            STSceneOpenExConfig rootConfig = STConfigManager.GetSceneOpenExConfig();
            STSceneOpenExSceneConfig  sceneConfig = rootConfig.GetCustom5SceneConfig;
            STSceneOpenManager.OpenScene(sceneConfig.GetBaseScene,sceneConfig.GetAddSceneList);
        }
        



    }
}