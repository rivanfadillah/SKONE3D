using System.Collections;
using UnityEngine;
using UnityEngine.XR.Management;

public class XRBoot : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return XRGeneralSettings.Instance.Manager.InitializeLoader();

        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            Debug.LogError("Gagal inisialisasi XR!");
        }
        else
        {
            XRGeneralSettings.Instance.Manager.StartSubsystems();
        }
    }

    void OnDisable()
    {
        XRGeneralSettings.Instance.Manager.StopSubsystems();
        XRGeneralSettings.Instance.Manager.DeinitializeLoader();
    }
}
