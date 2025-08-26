using Google.XR.Cardboard;
using UnityEngine;
using UnityEngine.XR.Management;
using System.Collections;

public class CardboardStartup : MonoBehaviour
{
    private bool xrStarted = false;

    IEnumerator Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.brightness = 1.0f;

        // Aktifkan XR secara manual
        yield return StartXR();

        // Cek Device Params setelah XR aktif
        if (!Api.HasDeviceParams())
        {
            Api.ScanDeviceParams();
        }
    }

    IEnumerator StartXR()
    {
        Debug.Log("Initializing XR...");
        yield return XRGeneralSettings.Instance.Manager.InitializeLoader();

        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            Debug.LogError("Gagal inisialisasi XR Loader.");
            yield break;
        }

        XRGeneralSettings.Instance.Manager.StartSubsystems();
        xrStarted = true;
        Debug.Log("XR berhasil dijalankan.");
    }

    void Update()
    {
        // Cek apakah XR sudah aktif
        if (!xrStarted) return;

        if (Api.IsGearButtonPressed)
        {
            Api.ScanDeviceParams();
        }

        if (Api.IsCloseButtonPressed)
        {
            Application.Quit();
        }

        if (Api.IsTriggerHeldPressed)
        {
            Api.Recenter();
        }

        if (Api.HasNewDeviceParams())
        {
            Api.ReloadDeviceParams();
        }

        // Baru jalankan ini setelah XR aktif
        
    }
}
