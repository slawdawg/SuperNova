using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class UnitController : MonoBehaviour
{
    private NavMeshAgent mNavMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        mNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse Button Pressed!");
            if (Physics.Raycast(ray, out hit, 10000))
            {
                Debug.Log("Raycast hit! point is " + hit.point);
                mNavMeshAgent.SetDestination(hit.point);
            }
            else
            {
                Debug.Log("Mouse Position is" + ray.origin);
                Debug.Log("Ray did not hit");
            }
        }

       /*
        * if (mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
        
        {
            // place code here to disable engine particles
        }
        */
    }

    void FixedUpdate()
    {
        var rb = GetComponent<Rigidbody>();

    }

    
}
