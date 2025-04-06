using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.ModOptions;

namespace TopDownCamera
{
    internal class Settings : ModSettings
    {
        public static readonly ModSettingHotkey toggleView = new(UnityEngine.KeyCode.T)
        {
            description = "Toggle between top down and normal viewing angle"
        };
    }
}
