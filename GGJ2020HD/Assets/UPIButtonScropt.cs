using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPIButtonScropt : MonoBehaviour
{
    public GameObject SpawnObject;
    public RepairSceneManager repairSceneManager;

    public void Spawn()
    {
        if (SpawnObject.GetComponent<FixingMaterialScript>())
        {
            if (SpawnObject.GetComponent<FixingMaterialScript>().Price>repairSceneManager.Bomber.GetComponent<BomberManager>().Buget)
                return;
        }
        Instantiate(SpawnObject, transform.position, transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
