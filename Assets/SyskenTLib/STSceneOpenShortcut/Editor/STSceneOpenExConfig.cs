using UnityEngine;

namespace SyskenTLib.STSceneOpenShortcutEditor
{
    public class STSceneOpenExConfig : ScriptableObject
    {
        [Header("Splash")] [SerializeField] private STSceneOpenExSceneConfig _splashSceneConfig;
        public STSceneOpenExSceneConfig GetSplashSceneConfig => _splashSceneConfig;
        
        [Header("Main")] [SerializeField] private STSceneOpenExSceneConfig _main1SceneConfig;
        public STSceneOpenExSceneConfig GetMain1SceneConfig => _main1SceneConfig;
        [SerializeField] private STSceneOpenExSceneConfig _main2SceneConfig;
        public STSceneOpenExSceneConfig GetMain2SceneConfig => _main2SceneConfig;
        [SerializeField] private STSceneOpenExSceneConfig _main3SceneConfig;
        public STSceneOpenExSceneConfig GetMain3SceneConfig => _main3SceneConfig;
        
        
        [Header("Custom")] [SerializeField] private STSceneOpenExSceneConfig _custom1SceneConfig;
        public STSceneOpenExSceneConfig GetCustom1SceneConfig => _custom1SceneConfig;
        [SerializeField] private STSceneOpenExSceneConfig _custom2SceneConfig;
        public STSceneOpenExSceneConfig GetCustom2SceneConfig => _custom2SceneConfig;
        [SerializeField] private STSceneOpenExSceneConfig _custom3SceneConfig;
        public STSceneOpenExSceneConfig GetCustom3SceneConfig => _custom3SceneConfig;
        [SerializeField] private STSceneOpenExSceneConfig _custom4SceneConfig;
        public STSceneOpenExSceneConfig GetCustom4SceneConfig => _custom4SceneConfig;
        [SerializeField] private STSceneOpenExSceneConfig _custom5SceneConfig;
        public STSceneOpenExSceneConfig GetCustom5SceneConfig => _custom5SceneConfig;

    }
}
