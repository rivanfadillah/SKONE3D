using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnablelbl : MonoBehaviour
{
    public GameObject Sesuatu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (Sesuatu.activeInHierarchy == true)
        {
            Sesuatu.SetActive(false);
        }
        else
        {
            Sesuatu.SetActive(true);
        }
    }
}