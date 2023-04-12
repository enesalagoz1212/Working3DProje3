using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MakeRaycast();
        }
    }

    void MakeRaycast()
    {
        RaycastHit hit;
        int range = 10;
        Debug.DrawRay(transform.position, transform.forward * range, Color.cyan);
       if(Physics.Raycast(transform.position,transform.forward,out hit,range))
        {
            Debug.Log("Objeye çarptým " + hit.transform.name);
        }
    }
}
