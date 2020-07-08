using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public BomberManager bomberManager;
    public int DamageType; //1:20mmGunHit 2:7.62mmGunHit 3:??? 4:20mmRepaired 5:7.62mmRepaired
    private GameObject FixMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FixingMaterial")
        {
            bomberManager.DamagedIntensity += other.GetComponent<FixingMaterialScript>().strength;
            bomberManager.Buget -= other.GetComponent<FixingMaterialScript>().Price;
            other.GetComponent<FixingMaterialScript>().FixDamage = gameObject;
            FixMaterial = other.gameObject;
            if (DamageType <= 3)
            {
                DamageType += 3;
            }
        }
    }

    public void Refine()
    {
        bomberManager.DamagedIntensity -= FixMaterial.GetComponent<FixingMaterialScript>().strength;
        bomberManager.Buget += FixMaterial.GetComponent<FixingMaterialScript>().Price;
        FixMaterial = null;
        if (DamageType >= 3)
        {
            DamageType -= 3;
        }
    }
}
