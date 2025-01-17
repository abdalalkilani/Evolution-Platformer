using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public Animator chestanimator;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D END){
        chestanimator.SetTrigger("Trigger");
    }
}
