using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaneeBoxMetarial : MonoBehaviour
{
    public Material material;

    private void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.tag=="Player")
        {
            GetComponent<MeshRenderer>().material = material;
        }
    }

    void Start()
    {




        /*
          GameObject[] boxes = GameObject.FindGameObjectsWithTag("box");
          for (int i = 0; i < boxes.Length; i++)
          {
              boxes[i].GetComponent<MeshRenderer>().material = material;
          }

        */


        /*
          GameObject yellowCube = GameObject.Find("YellowCube");
          GameObject greenCube = GameObject.Find("GreenCube");
          yellowCube.GetComponent<MeshRenderer>().material = material;
          greenCube.GetComponent<MeshRenderer>().material = material;
        */
    }


}
