using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class code_option : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void windoued(){
        if(Screen.fullScreen){
            Screen.fullScreen=false;
        }else{
            Screen.SetResolution(1280,900,true);
            Screen.fullScreen=true;
        }
    }
}
