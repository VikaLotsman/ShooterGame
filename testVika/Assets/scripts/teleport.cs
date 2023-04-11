using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{


    public Transform exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider  collision)
    {
        Debug.Log(collision.transform.name);
        hodba t = collision.transform.GetComponent<hodba>();
        if (t)
        {
            collision.transform.position = exit.position;
        }
    }
}
