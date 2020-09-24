﻿using UnityEngine;

public class GraphicsInitializer : MonoBehaviour {
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad() {
        ApplyGraphics();
    }

    public static void ApplyGraphics() {
        ApplyResolution();
        ApplyQuality();
    }

    private static void ApplyResolution() {
        var resolution_id = PlayerPrefs.GetInt("resolution_setting", -1);
        var fullscreen_mode = (FullScreenMode) PlayerPrefs.GetInt("fullscreen_setting", 0);

        if(Screen.resolutions.Length <= resolution_id || resolution_id < 0) { // Just select the highest one if we selected an invalid one
            resolution_id = Screen.resolutions.Length - 1;
        }

        Resolution new_res = Screen.resolutions[resolution_id];
        Resolution current_res = Screen.currentResolution;
        if(new_res.height != Screen.currentResolution.height || new_res.refreshRate != Screen.currentResolution.refreshRate || new_res.width != Screen.currentResolution.width) {
            Screen.SetResolution(new_res.width, new_res.height, fullscreen_mode, new_res.refreshRate);
        }
    }

    private static void ApplyQuality() {
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("quality_setting", 5), true);
    }
}
