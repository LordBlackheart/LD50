using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobTarget : MonoBehaviour
{
    public float health = 10f;
    public float mobDamage = 1f;
    public float healthLoss = 0.3f;

    // Update is called once per frame
    void Update() {
        health -= healthLoss * Time.deltaTime;
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Hit detected");
        if (hit.gameObject.tag == "Mob")
        {
            health -= mobDamage;

            if (health <= 0)
            {
                //To Be Changed
                Debug.Log("YOU DIED");
            }
        }
    }
}
