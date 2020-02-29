using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D Rigibody;

    public RuntimeAnimatorController left;
    public RuntimeAnimatorController right;
    Animator animator;

    bool anyCollision = true;

    private void Start()
    {
        animator = transform.gameObject.GetComponent<Animator>();
        Rigibody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerMove();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!anyCollision)
            anyCollision = true;        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {        
        if (anyCollision)
            anyCollision = false;     
    } 

    void PlayerMove()
    {
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && anyCollision)
            Rigibody.velocity = new Vector3(0, 7, 0); 




        //left
        if (Input.GetKey(KeyCode.A))
        {
            animator.runtimeAnimatorController = left as RuntimeAnimatorController;
            transform.Translate(-Vector3.right * 0.005f);           
        }
                    
        
        //right
        else if (Input.GetKey(KeyCode.D))
        {
            animator.runtimeAnimatorController = right as RuntimeAnimatorController;
            transform.Translate(Vector3.right * 0.005f);
        } 
                                              
    }
}
