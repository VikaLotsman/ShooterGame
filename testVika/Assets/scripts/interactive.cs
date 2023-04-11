using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class interactive : MonoBehaviour
{
   public virtual void Interact(head that_head)
    {
        Debug.Log("intr");
    }
}
