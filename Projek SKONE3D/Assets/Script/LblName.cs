using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LblName : MonoBehaviour
{
    public TMP_Text namaLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        namaLabel.transform.position = namePos;
    }
}