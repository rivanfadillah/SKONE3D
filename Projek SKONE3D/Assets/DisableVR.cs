using UnityEngine;
using UnityEngine.XR;
using System.Collections;
using System.Collections.Generic;

public class DisableVR : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(StopXRDisplay());
    }

    IEnumerator StopXRDisplay()
    {
        yield return null; // tunggu 1 frame agar XR ready

        // Matikan XR rendering
        List<XRDisplaySubsystem> displays = new List<XRDisplaySubsystem>();
        SubsystemManager.GetInstances(displays);

        foreach (XRDisplaySubsystem display in displays)
        {
            if (display.running)
            {
                display.Stop();
                Debug.Log("XR Display Stopped in splash/menu");
            }
        }

        // Matikan stereoscopic kamera
        if (Camera.main != null)
        {
            Camera.main.stereoTargetEye = StereoTargetEyeMask.None;
        }
    }
}
