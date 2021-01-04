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
        // ic = GetComponent<ImageChanger>();
    }

    private void FixedUpdate() {
        if (!td.IsTouching()) {
            // Debug.Log("4");
            // ic.Jump();
            animator.SetBool("isJumping", true);
            velocity.y -= _gravity*Time.deltaTime;
        }
        else {
            animator.SetBool("isJumping", false);
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        velocity.x = x * _speed;
        velocity.y += y * _jump_pulse;
        animator.SetFloat("speed",Mathf.Abs(x));
        // if(x ==0 && y ==0){
        //     Debug.Log("1");
        //     // ic.Stay();
        // }
        // if(x < 0){
        //     Debug.Log("2");
        //     // ic.WalkL();
        //     fc.addToSugar(lostOnWalk);
        // }
        // if(x > 0){
        //     Debug.Log("2");
        //     // ic.WalkR();
        //     fc.addToSugar(lostOnWalk);
        // }
        // if(y > 0){
        //     Debug.Log("3");
        //     fc.addToSugar(lostOnJump);
        //     // ic.Jump();
        // }
        
        velocity = transform.TransformDirection(velocity);
        transform.position += velocity * Time.deltaTime;
    }
    
}
