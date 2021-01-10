using UnityEngine;
/**
 *  This component allows the player to add force to its object using the arrow keys.
 *  Works with a 3D RigidBody.
 */
[RequireComponent(typeof(TouchDetector))]
public class KeyboardMover : MonoBehaviour {
    //serialize
    public Animator animator;
    [SerializeField] float _speed = 5f;
    [SerializeField] float _gravity = 9.81f;
    [SerializeField] float _jump_pulse;

    [Tooltip("How many sugar mario lost in walk")]
    [SerializeField] double lostOnWalk = -0.02;
    [Tooltip("How many sugar mario lost in jamp")]
    [SerializeField] double lostOnJump = -0.03;

    //private
    private Vector3 velocity;
    private TouchDetector td;
    private FieldsController fc;
    public float max_y = 2.52f;

    private Rigidbody2D rb;
    void Start() {
        td = GetComponent<TouchDetector>();
        fc = GetComponent<FieldsController>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        // update x
        float x = Input.GetAxis("Horizontal");
        velocity.x = x * _speed;

        // change direction
        if(x < 0) GetComponent<SpriteRenderer>().flipX = false;
        else GetComponent<SpriteRenderer>().flipX = true;

        // jump
        if(Input.GetAxis("Jump")!=0 && td.IsTouching()){
            rb.AddForce(new Vector2(0, _jump_pulse), ForceMode2D.Impulse);
            fc.addToSugar(lostOnJump);
        }

        // update position
        velocity = transform.TransformDirection(velocity);
        transform.position += velocity * Time.deltaTime;

        // update animation
        animator.SetFloat("speed", Mathf.Abs(x));
        animator.SetBool("isJumping", !td.IsTouching());
        animator.SetFloat("high",transform.position.y); //check if falling

        // update sugar
        if(x != 0) fc.addToSugar(lostOnWalk);
    }
    
}
