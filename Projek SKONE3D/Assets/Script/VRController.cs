using System.Collections;
using UnityEngine;
using UnityEngine.XR.Management;

public class VRController : MonoBehaviour
{
    // Aktifkan VR saat dibutuhkan
    public void EnterVR()
    {
        StartCoroutine(ActivateVR());
    }

    IEnumerator ActivateVR()
    {
        XRGeneralSettings xrSettings = XRGeneralSettings.Instance;

        if (xrSettings.Manager.activeLoader == null)
        {
            yield return xrSettings.Manager.InitializeLoader();
        }

        if (xrSettings.Manager.activeLoader != null)
        {
            xrSettings.Manager.StartSubsystems();
            Debug.Log("VR Mode Aktif");
        }
        else
        {
            Debug.LogError("XR Loader gagal diaktifkan.");
        }
    }

    // Matikan VR jika diperlukan
    public void ExitVR()
    {
        StartCoroutine(DeactivateVR());
    }

    IEnumerator DeactivateVR()
    {
        XRGeneralSettings xrSettings = XRGeneralSettings.Instance;

        if (xrSettings.Manager.activeLoader != null)
        {
            xrSettings.Manager.StopSubsystems();
            xrSettings.Manager.DeinitializeLoader();
            Debug.Log("VR Mode Dimatikan");
        }

        yield return null;
    }
}
