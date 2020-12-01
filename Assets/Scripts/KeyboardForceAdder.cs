﻿using UnityEngine;
/**
 *  This component allows the player to add force to its object using the arrow keys.
 *  Works with a 3D RigidBody.
 */
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(TouchDetector))]
public class KeyboardForceAdder : MonoBehaviour {
    [Tooltip("The horizontal force that the player's feet use for walking, in newtons.")]
    [SerializeField] float walkForce = 5f;

    [Tooltip("The vertical force that the player's feet use for jumping, in newtons.")]
    [SerializeField] float jumpImpulse = 5f;

    [Range(0,1f)]
    [SerializeField] float slowDownAtJump = 0.5f;

    private Rigidbody2D rb;
    private TouchDetector td;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        td = GetComponent<TouchDetector>();
    }

    private ForceMode2D walkForceMode2D = ForceMode2D.Force;
    private ForceMode2D jumpForceMode2D = ForceMode2D.Impulse;
    private bool playerWantsToJump = false;

    private void Update() {
        // Keyboard events are tested each frame, so we should check them here.
        if (Input.GetKeyDown(KeyCode.Space))
            playerWantsToJump = true;
    }

    /*
     * Note that updates related to the physics engine should be done in FixedUpdate and not in Update!
     */
    private void FixedUpdate() {
        if (td.IsTouching()) {  // allow to walk and jump 
            float horizontal = Input.GetAxis("Horizontal");
            rb.AddForce(new Vector3(horizontal* walkForce, 0, 0), walkForceMode2D);
            if (playerWantsToJump) {            // Since it is active only once per frame, and FixedUpdate may not run in that frame!
                rb.velocity = new Vector3(rb.velocity.x * slowDownAtJump, rb.velocity.y);
                rb.AddForce(new Vector3(0, jumpImpulse, 0), jumpForceMode2D);
                playerWantsToJump = false;
            } 
        }
    }
}
