using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSpiderSetup : MonoBehaviour
{
    private Notificator notificator;
    public float jumpForce = 1f;
    private Rigidbody rb;
    void Start()
    {
        notificator = Notificator.instance;
        notificator.OnLookatChest += Jump;
        rb = GetComponent<Rigidbody>();
    }

    void Jump()
    {
        if(Physics.Raycast(transform.position, -Vector3.up, GetComponent<Collider>().bounds.extents.y + 0.1f)) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
