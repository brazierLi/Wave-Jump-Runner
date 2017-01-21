using UnityEngine;
using System.Collections;

public class MoveCloser : MonoBehaviour {

    Player_Controller Player;

    public string MoveCloserTag = "Damage";
    public float RegularSpeed = 5,dist4OutOfRange = 15,outOfRange = 11, AddSpeed = 5;
    float currentAddSpeed = 0;

    void FixedUpdate () {
        Player = GameObject.Find("Player").GetComponent<Player_Controller>();
        if (Player.CurrentHitTag == MoveCloserTag)
        {
            currentAddSpeed += AddSpeed;
        }
        else {
            currentAddSpeed = 0;
        }
        if (GameObject.Find("Player").transform.position.y - transform.position.y > dist4OutOfRange)
        {
            currentAddSpeed += outOfRange;
        }
        else {
            currentAddSpeed += RegularSpeed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(RegularSpeed + currentAddSpeed, 0);
	}
}
