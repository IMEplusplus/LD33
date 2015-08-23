using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Rigidbody2D rig;
    public Weapon weapon;

    public KeyCode keyRight = KeyCode.D;
    public KeyCode keyLeft  = KeyCode.A;
    public KeyCode keyUp    = KeyCode.W;
    public KeyCode keyDown  = KeyCode.S;

    public bool toRight = true;

    [Range(0,10)]
    public float speed = 1f;

    void Awake() {
        rig = GetComponent<Rigidbody2D>();
    }
	
	void FixedUpdate() {
        if (!weapon.isAttacking) {
            bool lastToRight = toRight;

            if (Input.GetKey(keyRight)) {
                rig.position += speed * Vector2.right * Time.deltaTime;
                toRight = true;
            }
            if (Input.GetKey(keyLeft)) {
                rig.position += speed * Vector2.left * Time.deltaTime;
                toRight = false;
            }
            if (Input.GetKey(keyUp)) {
                rig.position += speed * Vector2.up * Time.deltaTime;
            }
            if (Input.GetKey(keyDown)) {
                rig.position += speed * Vector2.down * Time.deltaTime;
            }

            if (toRight && toRight != lastToRight) {
                transform.localScale = new Vector3(1, 1, 1);
            }
            if (!toRight && toRight != lastToRight) {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
	}
}
