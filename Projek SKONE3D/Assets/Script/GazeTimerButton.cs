using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GazeTimerButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float gazeTime = 2f; 
    public UnityEvent OnGazeComplete;
    public Image progressImage; 

    private float timer;
    private bool isGazing;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        if (progressImage != null)
        {
            progressImage.fillAmount = 0;
        }
    }

    void Update()
    {
        if (isGazing)
        {
            timer += Time.deltaTime;
            
            if (progressImage != null)
            {
                progressImage.fillAmount = timer / gazeTime;
            }

            if (timer >= gazeTime)
            {
                if (button != null)
                {
                    button.onClick.Invoke();
                }
                
                OnGazeComplete.Invoke();
                ResetGaze();
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isGazing = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ResetGaze();
    }

    private void ResetGaze()
    {
        isGazing = false;
        timer = 0f;
        if (progressImage != null)
        {
            progressImage.fillAmount = 0;
        }
    }
}