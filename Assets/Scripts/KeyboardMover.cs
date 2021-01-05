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
    [SerializeField] float _jump_pulse = 5f;

    [Tooltip("How many sugar mario lost in walk")]
    [SerializeField] double lostOnWalk = -0.02;
    [Tooltip("How many sugar mario lost in jamp")]
    [SerializeField] double lostOnJump = -0.03;

    //private
    private Vector3 velocity;
    private TouchDetector td;
    private FieldsChanger fc;
    // private ImageChanger ic;


    void Start() {
        td = GetComponent<TouchDetector>();
        fc = GetComponent<FieldsChanger>();
    }

    private void FixedUpdate() {
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        velocity.x = x * _speed;
        velocity.y += y * _jump_pulse;
        
        if(x < 0) GetComponent<SpriteRenderer>().flipX = true;
        else GetComponent<SpriteRenderer>().flipX = false;

        animator.SetFloat("speed",Mathf.Abs(x));
        
        if (!td.IsTouching()) {
            animator.SetBool("isJumping", true);
            velocity.y -= _gravity*Time.deltaTime;
        }
        else {
            animator.SetBool("isJumping", false);
        }
        
        velocity = transform.TransformDirection(velocity);
        transform.position += velocity * Time.deltaTime;
        GetComponent<FieldsChanger>().addToSugar(lostOnWalk);
    }
    
}
