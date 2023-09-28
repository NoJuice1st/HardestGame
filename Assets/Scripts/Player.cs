using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 10;
    Vector3 moveDir;
    private Vector3 spawnPoint;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPoint = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        //movement

        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.z = Input.GetAxisRaw("Vertical");

        //transform.position += moveDir * speed * Time.deltaTime;
        rb.velocity = moveDir * speed;

        if(moveDir != Vector3.zero)transform.forward = moveDir;
    }

    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Contains("Enemy"))
        {
            Die();
        }
    }
}
