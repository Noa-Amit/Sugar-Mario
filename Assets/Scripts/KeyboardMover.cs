using UnityEngine;
/**
 *  This component allows the player to add force to its object using the arrow keys.
 *  Works with a 3D RigidBody.
 */
[RequireComponent(typeof(TouchDetector))]
public class KeyboardMover : MonoBehaviour {
    private TouchDetector td;
    private Vector3 velocity;
    [SerializeField] float _speed = 5f;
    [SerializeField] float _gravity = 9.81f;
    [SerializeField] float _jump_pulse = 3f;

    [Tooltip("How many sugar mario lost in walk")]
    [SerializeField] double lostOnWalk = -0.02;
    [Tooltip("How many sugar mario lost in jamp")]
    [SerializeField] double lostOnJump = -0.03;

    void Start() {
        td = GetComponent<TouchDetector>();
    }

    private void FixedUpdate() {
        if(Input.GetAxis("Horizontal") != 0){
            GetComponent<FieldsChanger>().addToSugar(lostOnWalk);
        }
        float x = Input.GetAxis("Horizontal");
        velocity.x = x * _speed;
        if (Input.GetAxis("Jump") !=0) {
            velocity += new Vector3(Input.GetAxis("Horizontal"), _jump_pulse);
            GetComponent<FieldsChanger>().addToSugar(lostOnJump);
        }
        if (!td.IsTouching()) {
            velocity.y -= _gravity*Time.deltaTime;
        }
        velocity = transform.TransformDirection(velocity);
        transform.position += velocity * Time.deltaTime;
    }
    
}
