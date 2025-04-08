using MelonLoader;
using BTD_Mod_Helper;
using TopDownCamera;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;

[assembly: MelonInfo(typeof(TopDownCamera.TopDownCamera), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TopDownCamera;

public class TopDownCamera : BloonsTD6Mod
{
    bool topDown = false;

    public override void OnApplicationStart()
    {
        ModHelper.Msg<TopDownCamera>("TopDownCamera loaded!");
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (InGame.instance?.bridge == null) return;

        if (PopupScreen.instance.IsPopupActive()) return;

        if (Settings.toggleView.JustPressed())
        {            
            topDown = !topDown;

            if (topDown)
            {
                ModHelper.Msg<TopDownCamera>("Toggling view to topdown");
                InGame.instance.sceneCamera.transform.rotation = Quaternion.Euler(90, 0, 0);
                InGame.instance.sceneCamera.orthographicSize = 116;
            }
            else
            {
                ModHelper.Msg<TopDownCamera>("Toggling view to normal");
                InGame.instance.sceneCamera.transform.rotation = Quaternion.Euler(60, 0, 0);
                InGame.instance.sceneCamera.orthographicSize = 100;
            }
        }
    }
}