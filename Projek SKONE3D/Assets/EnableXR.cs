using UnityEngine;
using UnityEngine.XR;
using System.Collections;
using System.Collections.Generic;

public class EnableXRInVRScene : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.1f); // tunggu sedikit

        List<XRDisplaySubsystem> displays = new List<XRDisplaySubsystem>();
        SubsystemManager.GetInstances(displays);

        foreach (var display in displays)
        {
            if (!display.running)
            {
                display.Start();
                Debug.Log("? XR Display started in VR scene");
            }
        }

        if (Camera.main != null)
        {
            Camera.main.stereoTargetEye = StereoTargetEyeMask.Both;
        }
    }
}
