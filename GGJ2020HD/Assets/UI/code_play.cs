using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class code_play : MonoBehaviour 
{
    float size0=93.3f;
    float size1=129.06f;
    float startspd=1f;
    float dirspd;
    bool entered=false;
    public Texture t0;
    public Texture t1;
    private Texture image;
    void changetexture(Texture t){
        GetComponent<RawImage>().texture=t;
    } 
    void Start()
    {
        dirspd=startspd;
        changetexture(t0);
        
    }
    // Update is called once per frame
    void Update()
    {
        entered=IsCursorOnUI();
        transform.Rotate(0f,0f,dirspd);
        if(entered){
            if(dirspd<15 || GetComponent<RawImage>().texture==t0)
                dirspd+=0.1f;
        }else{
            if(dirspd>=startspd){
                dirspd-=0.1f;
            }
        }
        if(dirspd>30 && GetComponent<RawImage>().texture==t0 && entered){
            dirspd=1;
            changetexture(t1);
        }
        if(dirspd<startspd && GetComponent<RawImage>().texture==t1 && !entered){
            dirspd=30;
            changetexture(t0);
        }
        
    }
    public void play(){
        SceneManager.LoadScene("Fixing");
    }
    public static bool IsCursorOnUI(int inputID=-1){
        EventSystem eventSystem = EventSystem.current;
        return ( eventSystem.IsPointerOverGameObject( inputID ) );
        
    }
    
    
}
