using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void DestroyObject()
    {
        Debug.Log("destroyed");
        Destroy(gameObject);
    }
}
