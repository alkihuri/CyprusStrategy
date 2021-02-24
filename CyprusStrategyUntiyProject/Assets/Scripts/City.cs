using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public string cityName;
    // Start is called before the first frame update
    void Start()
    {
        cityName = name;
    }

     private void OnTriggerExit(Collider collider)
     {
         collider.gameObject.GetComponentInChildren<Light>().color = Color.red;
         Debug.Log(name + " is passed");
     }

     private void OnTriggerEnter(Collider collider)
     {
         collider.gameObject.GetComponentInChildren<Light>().color = Color.green;
         Debug.Log("Arrived to " + name);
     }
}
