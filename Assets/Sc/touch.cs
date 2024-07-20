using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TR�GGER ENTER");
        Destroy(other.gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TR�GGER STAY");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TR�GGER EX�T");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLL�S�ON ENTER");
        Destroy(collision.gameObject);
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("COLL�S�ON STAY");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("COLL�S�ON EX�T");
    }
}
