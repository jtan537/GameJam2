using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	public Rigidbody _rb;
    public float sidewaysForce = 10f;
	public bool moveLeft = false;
	public bool moveRight = false;
	public bool moveUp = false;

    public float _jumpDelay = 2f;
    public bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
       _rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        moveLeft = Input.GetKey("a");
    	moveRight = Input.GetKey("d");
		moveUp = Input.GetButtonDown("Jump");
        if (canJump && moveUp)
        {
            _rb.AddForce(Vector3.up * 13, ForceMode.VelocityChange);
            canJump = false;
            StartCoroutine(JumpDelay());
        }
    }

    void FixedUpdate()
    {
        if (moveRight){
            _rb.AddForce(Vector3.right, ForceMode.VelocityChange);
        }
        if (moveLeft){
            _rb.AddForce(Vector3.left, ForceMode.VelocityChange);
        }
    }

    private IEnumerator JumpDelay()
    {
        yield return new WaitForSeconds(_jumpDelay);
        canJump = true;
    }
}
