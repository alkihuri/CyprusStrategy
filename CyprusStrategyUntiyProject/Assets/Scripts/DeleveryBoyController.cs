using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DeleveryBoyController : MonoBehaviour
{


    NavMeshAgent navigation; 
    GameManager gameManager; 
    [Range(0,6)]public float offset  = 3;
      Vector3 randomCity ; 
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        navigation = GetComponent<NavMeshAgent>();
        randomCity = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      

        if(Vector3.Distance(transform.position , randomCity) < offset || navigation.velocity.magnitude<0.1f)
        {
            randomCity = gameManager.cities[Random.Range(0,gameManager.cities.Count)].transform.position;
        }
        navigation.SetDestination(randomCity);
    }
}
