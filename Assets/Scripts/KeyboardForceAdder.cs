using UnityEngine;
/**
 *  This component allows the player to add force to its object using the arrow keys.
 *  Works with a 3D RigidBody.
 */
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(TouchDetector))]
public class KeyboardForceAdder : MonoBehaviour {
    // [Tooltip("The horizontal force that the player's feet use for walking, in newtons.")]
    // [SerializeField] float walkForce = 5f;

    // [Tooltip("The vertical force that the player's feet use for jumping, in newtons.")]
    // [SerializeField] float jumpImpulse = 5f;

    // [Range(0,1f)]
    // [SerializeField] float slowDownAtJump = 0.5f;

    // private Rigidbody2D rb;
    private TouchDetector td;
    void Start() {
        // rb = GetComponent<Rigidbody2D>();
        td = GetComponent<TouchDetector>();
    }

    // private ForceMode2D walkForceMode2D = ForceMode2D.Force;
    // private ForceMode2D jumpForceMode2D = ForceMode2D.Impulse;
    // private bool playerWantsToJump = false;

    [SerializeField] float _speed = 5f;
    [SerializeField] float _gravity = 9.81f;
    [SerializeField] float _jump_pulse = 3f;

    // private void Update() {
    //     // Keyboard events are tested each frame, so we should check them here.
    //     // if (Input.GetKeyDown(KeyCode.Space))
    //     //     playerWantsToJump = true;
    // }

    /*
     * Note that updates related to the physics engine should be done in FixedUpdate and not in Update!
     */
    Vector3 velocity;
    private void FixedUpdate() {
        float x = Input.GetAxis("Horizontal");
        velocity.x = x * _speed;
        if (Input.GetAxis("Jump") != 0) {
            velocity += new Vector3(Input.GetAxis("Horizontal"), _jump_pulse);
        }
        if (!td.IsTouching()) {
            velocity.y -= _gravity*Time.deltaTime;
        }
        velocity = transform.TransformDirection(velocity);
        transform.position += velocity * Time.deltaTime;
    }
    
}
