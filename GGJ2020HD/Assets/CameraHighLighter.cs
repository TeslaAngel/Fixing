using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHighLighter : MonoBehaviour
{
    public float HightLightedFOV;
    public float OriginFOV;
    // Start is called before the first frame update
    void Start()
    {
        OriginFOV = GetComponent<Camera>().fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Camera>().fieldOfView = Vector3.Lerp(new Vector3(GetComponent<Camera>().fieldOfView, 0, 0), new Vector3(HightLightedFOV, 0, 0), 0.5f * Time.deltaTime).x;

        }
        else
        {
            GetComponent<Camera>().fieldOfView = Vector3.Lerp(new Vector3(GetComponent<Camera>().fieldOfView, 0, 0), new Vector3(OriginFOV, 0, 0), 0.5f*Time.deltaTime).x;
        }
    }
}
