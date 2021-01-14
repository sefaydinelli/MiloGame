using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    public List<string> items;

    private const float MOVE_SPEED = 5f;
    private Rigidbody2D rb2d;
    private Vector3 moveDir;
    public Joystick joystick;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveDir = new Vector3(joystick.Horizontal, joystick.Vertical).normalized;
    }
    private void FixedUpdate()
    {
        rb2d.velocity = moveDir * MOVE_SPEED;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bones"))
        {
            string itemName = collision.gameObject.GetComponent<Collectable>().itemName;
            print(itemName + " collected.");

            items.Add(itemName);
            print("Collected item count : " + items.Count);

            Destroy(collision.gameObject);
            
        }
    }
}
