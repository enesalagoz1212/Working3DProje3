using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(" Ana Obje : "+ this.gameObject.name + " Çarpan : " + collision.gameObject.name);
    } 

    private void OnCollisionExit(Collision collision)
    {// carpýsma bittiði an calýsan 
        
    }


    private void OnCollisionStay(Collision collision)
    {// iki birbirine  carpýstý ve carpiþmaya devam ediyor
        Debug.Log(collision.gameObject.name + " ile çarpýþma devam ediyor");
    }
}
