using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageMarkIndicator : MonoBehaviour
{
    public List<GameObject> Damages;
    public GameObject[] Markers;
    public bool IsFreeze;

    public Sprite Marker1;
    public Sprite Marker2;
    public Sprite MarkerG1;
    public Sprite MarkerG2;

    public void Define()
    {
        var  ADamages = GameObject.FindGameObjectsWithTag("Damage");
        for(int I = 0; I < ADamages.Length; I++)
        {
            Damages.Add(ADamages[I]);
            Markers[I].SetActive(true);
        }

        for(int I = Damages.Count; I < Markers.Length; I++)
        {
            Markers[I].SetActive(false);
        }
        IsFreeze = false;
    }

    public void Freeze()
    {
        for(int I = 0; I < Damages.Count; I++)
        {
            Damages.Remove(Damages[I]);
        }
        for (int I = 0; I < Markers.Length; I++)
        {
            Markers[I].SetActive(false);
        }
        IsFreeze = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Define();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFreeze == true)
            return;

        for (int I = 0; I < Damages.Count; I++)
        {
            if (Damages[I] == null || !Damages[I])
            {
                Damages.Remove(Damages[I]);
            }
        }

        for (int I = 0; I < Damages.Count; I++)
        {
            Markers[I].SetActive(true);
        }
        for (int I = Damages.Count; I < Markers.Length; I++)
        {
            Markers[I].SetActive(false);
        }

        for (int I = 0; I < Damages.Count; I++)
        {
            Markers[I].transform.position = Camera.main.WorldToScreenPoint(Damages[I].transform.position);
            //print(Damages[I].transform.position);
            int MDT = Damages[I].GetComponent<DamageScript>().DamageType;
            if (MDT==1)
            {
                Markers[I].GetComponent<Image>().sprite = Marker1;
            }
            if (MDT == 2)
            {
                Markers[I].GetComponent<Image>().sprite = Marker2;
            }
            if (MDT == 4)
            {
                Markers[I].GetComponent<Image>().sprite = MarkerG1;
            }
            if (MDT == 5)
            {
                Markers[I].GetComponent<Image>().sprite = MarkerG2;
            }
        }
    }
}
