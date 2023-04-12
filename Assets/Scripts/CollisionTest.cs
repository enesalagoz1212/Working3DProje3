using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(" Ana Obje : "+ this.gameObject.name + " �arpan : " + collision.gameObject.name);
    } 

    private void OnCollisionExit(Collision collision)
    {// carp�sma bitti�i an cal�san 
        
    }


    private void OnCollisionStay(Collision collision)
    {// iki birbirine  carp�st� ve carpi�maya devam ediyor
        Debug.Log(collision.gameObject.name + " ile �arp��ma devam ediyor");
    }
}
