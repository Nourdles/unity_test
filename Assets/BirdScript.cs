using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent< LogicScript >();
    }  

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Jump", false);

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
            animator.SetBool("Jump", true);
        }

        if (-11 > transform.position.y || transform.position.y > 12)
        {
            logic.GameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
