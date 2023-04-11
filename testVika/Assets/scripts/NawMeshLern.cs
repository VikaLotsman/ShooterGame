using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NawMeshLern : MonoBehaviour
{
    NavMeshAgent a;
    public Transform p;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<NavMeshAgent>();
        a.destination =new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        a.destination = p.position;
    }
}
