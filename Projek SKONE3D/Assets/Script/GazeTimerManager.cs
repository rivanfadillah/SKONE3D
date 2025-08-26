using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeTimerManager : MonoBehaviour
{
    // Durasi tatapan yang diperlukan (dalam detik)
    public float gazeTime = 2f; 
    
    // Tombol UI yang sedang ditatap
    private Button currentButton;
    private float timer;

    public void OnPointerEnterButton(Button button)
    {
        currentButton = button;
        timer = 0f;
    }

    public void OnPointerExitButton(Button button)
    {
        if (currentButton == button)
        {
            currentButton = null;
            timer = 0f;
        }
    }

    void Update()
    {
        if (currentButton != null)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                currentButton.onClick.Invoke();
                currentButton = null;
                timer = 0f;
            }
        }
    }
}
