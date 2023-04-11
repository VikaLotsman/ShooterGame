using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handble : interactive
{


    public override void Interact(head that_head)
    {
        if (that_head.RightHandObject == null)
        {
            that_head.RightHandObject = this.gameObject;
        }
        transform.parent = that_head.transform;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().enabled = false;

        transform.position = that_head.transform.position+that_head.transform.forward*7 - that_head.transform.up * 4;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
