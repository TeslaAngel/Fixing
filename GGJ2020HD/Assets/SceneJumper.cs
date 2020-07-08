using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneJumper : MonoBehaviour {

    public string SceneToJump;

    public void Jump()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(SceneToJump);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
            Jump();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
