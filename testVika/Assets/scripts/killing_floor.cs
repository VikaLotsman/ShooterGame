using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killing_floor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);
        hodba t = collision.transform.GetComponent<hodba>();
        if (t)
        {
            t.Die();
        }
    }
}
