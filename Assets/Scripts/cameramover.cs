using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramover : MonoBehaviour
{
    public Transform cam;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")//send camera to next levels if player is there
        { cam.transform.position = this.transform.position; }
    }
}
