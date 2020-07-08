using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixingMaterialScript : MonoBehaviour
{
    public float strength;
    public float Price;
    public GameObject FixDamage;
    public bool Dragging;

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Damage")
        {
            FixDamage = other.gameObject;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Dragging == false)
            {
                print("1");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    print("2");

                    if (hit.collider.gameObject == gameObject || hit.collider.gameObject == FixDamage)
                    {
                        Destroy(gameObject);
                    }
                    else
                    {
                        print(hit.collider.gameObject);
                    }
                }
            }
            else
            {
                //Dragging = false;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag == "Damage")
                    {
                        transform.position = hit.collider.gameObject.transform.position;
                        transform.parent = hit.collider.gameObject.transform;
                        transform.rotation = hit.collider.gameObject.transform.rotation;
                        Dragging = false;
                    }
                }
            }
        }

        if (Dragging == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                transform.position = hit.point;
            }
            GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            GetComponent<BoxCollider>().enabled = true;
        }
    }

    private void OnDestroy()
    {
        FixDamage.GetComponent<DamageScript>().Refine();
    }
}
