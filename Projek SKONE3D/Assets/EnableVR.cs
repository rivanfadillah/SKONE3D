using UnityEngine;
using UnityEngine.XR.Management;
using System.Collections;

public class VRLoader : MonoBehaviour
{
    public void StartVR()
    {
        StartCoroutine(LoadVR());
    }

    IEnumerator LoadVR()
    {
        XRGeneralSettings.Instance.Manager.InitializeLoaderSync();

        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            Debug.LogError("Gagal inisialisasi XR loader.");
            yield break;
        }

        XRGeneralSettings.Instance.Manager.StartSubsystems();
        Debug.Log("VR Mode aktif.");
    }

    public void StopVR()
    {
        XRGeneralSettings.Instance.Manager.StopSubsystems();
        XRGeneralSettings.Instance.Manager.DeinitializeLoader();
        Debug.Log("VR Mode dimatikan.");
    }
}
