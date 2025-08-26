using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxManager : MonoBehaviour
{
    public Material sky1;
    public Material sky2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetSkybox1(){
        RenderSettings.skybox = sky1;
    }
    public void SetSkybox2(){
        RenderSettings.skybox = sky2;
    }
    public void SetSkybox(Material mat){
        RenderSettings.skybox = mat;
    }
    
}
