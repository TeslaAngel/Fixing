using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberManager : MonoBehaviour
{
    public List<GameObject> Damages;
    public float DamagedIntensity;
    public float Buget;
    public float DamagePossibilities;
    [Space]
    public bool Engine;
    public float SpeedF;
    private float IsF = 0;
    public float SpeedU;
    private float IsU = 0;
    public float TimeTextAfter;

    public void BomberWake()
    {
        GameObject[] DAFs = GameObject.FindGameObjectsWithTag("Damage");
        for (int I = 0; I < DAFs.Length; I++)
        {
            if (Random.Range(0, 10) < DamagePossibilities)
            {
                Destroy(DAFs[I]);
            }
            else
            {
                Damages.Add(DAFs[I]);
            }
        }

        DamagedIntensity = 100;
        for (int I = 0; I < Damages.Count; I++)
        {
            if (Damages[I] != null)
                DamagedIntensity -= 10;
            else
                Damages.Remove(Damages[I]);
        }

        Buget = Damages.Count * 5;
    }

    private void Awake()
    {
        GameObject[] DAFs = GameObject.FindGameObjectsWithTag("Damage");
        for(int I = 0; I < DAFs.Length; I++)
        {
            if (Random.Range(0, 10) < DamagePossibilities)
            {
                Destroy(DAFs[I]);
            }
            else
            {
                Damages.Add(DAFs[I]);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //GameObject[] DAFs = GameObject.FindGameObjectsWithTag("Damage");
        //for(int I = 0; I < DAFs.Length; I++)
        //{
        //    if (DAFs[I].transform.parent = transform)
        //    {
        //        Damages.Add(DAFs[I]);
        //    }
        //}

        //DamagedIntensity = 100 - Damages.Count*10;
        DamagedIntensity = 100;
        for (int I = 0; I < Damages.Count; I++)
        {
            if (Damages[I] != null)
                DamagedIntensity -= 10;
            else
                Damages.Remove(Damages[I]);
        }

        Buget = Damages.Count * 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Engine == true)
        {
            if (IsF < SpeedF)
                IsF += 10;
            if (IsU < SpeedU)
                IsU += 1;
            transform.Translate(0, IsU * Time.deltaTime, IsF * Time.deltaTime);

            TimeTextAfter -= Time.deltaTime;
            if (TimeTextAfter <= 0)
            {
                if (DamagedIntensity >= 65)
                {

                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
