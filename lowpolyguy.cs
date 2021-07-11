using UnityEngine;

public class lowpolyguy : MonoBehaviour
{
    public float Movespeed = 4.0f;
    public float Turnspeed = 45f;
    public float Jumpforce = 8.0f;
    private Rigidbody rb = null;
    private Animator anim = null;
    private bool isJumping = false;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        anim = this.GetComponent<Animator>();
    }
    private void Update()
    {
        //moving forward
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            this.transform.Translate(Vector3.forward * Movespeed * Time.deltaTime);
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }

        //turning
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            this.transform.Rotate(Vector3.up, Turnspeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            this.transform.Rotate(Vector3.up, -Turnspeed * Time.deltaTime);
        }

        //jump
        if (Input.GetKeyDown(KeyCode.Space) == true && isJumping == false)
        {
            anim.SetTrigger("jump");
            isJumping = true;
        }
    }
    public void ApplyJumpUpForce()
    {
        rb.AddRelativeForce(Vector3.up * Jumpforce, ForceMode.VelocityChange);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isJumping == true)
        {
            isJumping = false;
            anim.SetTrigger("land");
        }
    }
}
