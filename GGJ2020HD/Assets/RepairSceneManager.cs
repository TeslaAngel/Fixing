using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepairSceneManager : MonoBehaviour
{
    public TMP_Text DIShower;
    public TMP_Text BugetShower;
    public GameObject Bomber;

    public GameObject PageS;
    public GameObject PageF;

    public void ReDefineScene()
    {
        Bomber = GameObject.FindGameObjectWithTag("Bomber");
        PageF.SetActive(false);
        PageS.SetActive(false);
    }

    public void FinishFixing()
    {
        Bomber.GetComponent<BomberManager>().Engine = true;
        if (Bomber.GetComponent<BomberManager>().DamagedIntensity >= 65)
        {
            PageS.SetActive(true);
        }
        else
        {
            PageF.SetActive(true);
        }
        GetComponent<DamageMarkIndicator>().Freeze();
    }

    // Start is called before the first frame update
    void Start()
    {
        ReDefineScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<DamageMarkIndicator>().IsFreeze == false)
        {
            DIShower.text = Bomber.GetComponent<BomberManager>().DamagedIntensity.ToString();
            BugetShower.text = Bomber.GetComponent<BomberManager>().Buget.ToString();
        }
    }
}
