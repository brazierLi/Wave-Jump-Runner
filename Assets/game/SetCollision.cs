using UnityEngine;
using System.Collections;

public class SetCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col) {
        Debug.Log("Hit");
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
    void OnCollisionExit2D(Collision2D col) {
        Debug.Log("Trought");
        GetComponent<BoxCollider2D>().isTrigger = true;
    }
}
