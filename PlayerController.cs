using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float forwardInput;
    private float horizontalRotation;
    private float horizontalInput;
    [SerializeField] private float speed = 3;
    private Rigidbody playerRb;
    private int growth=0;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * (forwardInput * speed * Time.deltaTime));
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontalInput * speed * Time.deltaTime));
        horizontalRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, horizontalRotation, 0);
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Pickup"))
            
            Destroy(collision.gameObject);
            Debug.Log(growth);
            growth++;
          
        
    }
}
