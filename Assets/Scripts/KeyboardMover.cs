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
    private FieldsChanger fc;
    public float max_y = 2.52f;

    private Rigidbody2D rb;
    void Start() {
        td = GetComponent<TouchDetector>();
        fc = GetComponent<FieldsChanger>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        float x = Input.GetAxis("Horizontal");

        if(x < 0) GetComponent<SpriteRenderer>().flipX = false;
        else GetComponent<SpriteRenderer>().flipX = true;

        velocity.x = x * _speed;

        if(Input.GetKeyDown(KeyCode.Space)&&td.IsTouching()){
            rb.AddForce(new Vector2(0, _jump_pulse), ForceMode2D.Impulse);
        }


        animator.SetFloat("speed", Mathf.Abs(x));
        animator.SetBool("isJumping", !td.IsTouching());
        
        velocity = transform.TransformDirection(velocity);
        transform.position += velocity * Time.deltaTime;

        GetComponent<FieldsChanger>().addToSugar(lostOnWalk);
    }
    
}
