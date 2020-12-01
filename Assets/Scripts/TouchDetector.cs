using UnityEngine;


/**
 *  This component checks whether its object touches a collider of a given kind.
 *  Works with a 3D RigidBody.
 */
[RequireComponent(typeof(Rigidbody2D))]
public class TouchDetector : MonoBehaviour {
    [SerializeField] LayerMask layerMask;

    [Header("This field is for display only")]
    [SerializeField] private int touchingColliders = 0;

    private Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if ((layerMask.value & (1 << collision.gameObject.layer)) > 0)
            touchingColliders++;
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if ((layerMask.value & (1 << collision.gameObject.layer)) > 0)
            touchingColliders--;
    }

    public bool IsTouching() {
        return touchingColliders>0;
    }
}
