using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kontroller : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;

    private bool basladi = false;

    private float RekorSkor=0.0f;

    public Text scoreText;
    public Text bslText;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0;
        rb2d.velocity = Vector3.zero;

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && basladi == false){

            basladi = true;
            bslText.gameObject.SetActive(false);
            rb2d.gravityScale = 5f;

        }

        if (basladi == true)
        {


            if (moveInput < 0)
            {
                this.GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
            if (rb2d.velocity.y > 0 && transform.position.y > RekorSkor)
            {
                RekorSkor = transform.position.y;

            }
            scoreText.text = "Puan: " + Mathf.Round(RekorSkor).ToString();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (basladi == true)
        {

            moveInput = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
        }
        
    }
}
