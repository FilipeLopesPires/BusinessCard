﻿using UnityEngine;
using System.Collections;
using Vuforia;

public class CameraFocusController : MonoBehaviour {

    private bool mVuforiaStarted = false;

    void Start() {
        VuforiaARController vuforia = VuforiaARController.Instance;
        if (vuforia != null) {
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
        }
    }

    private void StartAfterVuforia() {
        mVuforiaStarted = true;
        SetAutofocus();
    }

    void OnApplicationPause(bool pause) {
        if (!pause) {
            if (mVuforiaStarted) {
                SetAutofocus(); 
            }
        }
    }

    private void SetAutofocus() {
        if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO)) {
            Debug.Log("Autofocus set");
        } else {
            Debug.Log("this device doesn't support auto focus");
        }
    }
}