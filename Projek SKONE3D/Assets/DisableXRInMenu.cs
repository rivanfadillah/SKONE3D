using UnityEngine;
using UnityEngine.XR;
using System.Collections;
using System.Collections.Generic;

public class DisableXRInMenu : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.1f); // tunggu sejenak agar splash selesai

        List<XRDisplaySubsystem> displays = new List<XRDisplaySubsystem>();
        SubsystemManager.GetInstances(displays);

        foreach (var display in displays)
        {
            if (display.running)
            {
                display.Stop();
                Debug.Log("? XR Display stopped in menu");
            }
        }

        // Optional: set kamera agar tidak split
        if (Camera.main != null)
        {
            Camera.main.stereoTargetEye = StereoTargetEyeMask.None;
        }
    }
}
