using System.Collections;
using UnityEngine;
using UnityEngine.XR.Management;

public class VRNo : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DeactivateVR());
    }

    IEnumerator DeactivateVR()
    {
        XRGeneralSettings xrSettings = XRGeneralSettings.Instance;

        if (xrSettings == null || xrSettings.Manager == null)
        {
            Debug.LogError("XR General Settings atau XR Manager tidak ditemukan.");
            yield break;
        }

        if (xrSettings.Manager.activeLoader != null)
        {
            xrSettings.Manager.StopSubsystems();
            xrSettings.Manager.DeinitializeLoader();
            Debug.Log("XR (VR) dinonaktifkan.");
        }
        else
        {
            Debug.Log("Tidak ada XR Loader aktif.");
        }

        yield return null;
    }
}
