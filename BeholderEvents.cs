using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeholderEvents : MonoBehaviour
{
    private Notificator notificator;
    public float teleportDistance = 10f;
    public float dangerousDistance = 2f;
    public int HP = 100;
    private SphereCollider triggerCollider;
    void Start()
    {
        notificator = Notificator.instance;
        notificator.OnPressT += Teleport;
        triggerCollider = GetComponent<SphereCollider>();
    }

    void Update()
    {
        triggerCollider.radius = dangerousDistance;
    }

    void Teleport()
    {
        transform.position = new Vector3(Random.Range(0,teleportDistance), 0, Random.Range(0,teleportDistance));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chest")
        {
            notificator.InvokeOnCollideChest();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "spider")
        {
            HP -= 10;
        }
    }


}
