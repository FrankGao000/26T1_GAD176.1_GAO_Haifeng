using UnityEngine;

public class enemy : MonoBehaviour
{
   [SerializeField] private float MovementSpeed = 8;
   [SerializeField] private Rigidbody rb;


    private void FixedUpdate()
    {
        //rb.MovePosition(transform.position + transform.forward * MovementSpeed * Time.fixedDeltaTime);
        rb.AddForce(transform.forward * MovementSpeed * Time.fixedDeltaTime);
    }
}
