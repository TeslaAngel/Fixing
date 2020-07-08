using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class code_op : MonoBehaviour 
{
    float startspd=2f;
    float dirspd;
    bool entered=false;
    void Start()
    {
        dirspd=startspd;
    }
    // Update is called once per frame
    void Update()
    {
        entered=IsCursorOnUI(10);
        transform.Rotate(0f,0f,dirspd);
        if(entered){
            if(dirspd<45)
                dirspd+=0.1f;
        }else{
            if(dirspd>=startspd){
                dirspd-=0.1f;
            }
        }
    }
    public static bool IsCursorOnUI(int inputID=-1){
        EventSystem eventSystem = EventSystem.current;
        return ( eventSystem.IsPointerOverGameObject( inputID ) );
    }
}
