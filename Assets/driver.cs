using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{

    // variables 
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 25f;
    bool speedStatus = false;

    // [SerializeField] float steerSpeed = 1f;
    // [SerializeField] float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }


     private void OnTriggerEnter2D(Collider2D other) 
        {
            if (other.tag == "SpeedUp" && speedStatus == false) 
            {
                moveSpeed = boostSpeed;
                speedStatus = true;
                Destroy(other.gameObject);

            }

            if (other.tag == "SlowDown" && moveSpeed > 1) 
            {
                moveSpeed = moveSpeed - slowSpeed;

                if (moveSpeed <= 0) {
                    moveSpeed = moveSpeed + 1;
                }
                Destroy(other.gameObject);
            } 
        }

    
}
