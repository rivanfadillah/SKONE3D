using System.Collections;
using UnityEngine;
using UnityEngine.XR.Management;

public class XRStarter : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("Memulai XR...");
        yield return XRGeneralSettings.Instance.Manager.InitializeLoader();

        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            Debug.LogError("Gagal memuat XR loader.");
        }
        else
        {
            XRGeneralSettings.Instance.Manager.StartSubsystems();
            Debug.Log("XR berhasil dijalankan.");
        }
    }
}

