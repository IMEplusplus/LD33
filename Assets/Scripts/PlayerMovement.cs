using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Rigidbody2D rig;
    Animator animator;

    public Weapon weapon;

    [Range(0,10)]
    public float speed = 1f;

    void Awake() {
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
	
	void Update() {
        if (!weapon.isAttacking) {

            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            rig.velocity = speed * new Vector3(x, y);

            if (x > 0) transform.localScale = new Vector3(1, 1, 1);
            if (x < 0) transform.localScale = new Vector3(-1, 1, 1);

            //if (Input.GetKey(keyRight))
            //{
            //    rig.velocity += speed * Vector2.right;
            //    toRight = true;
            //}
            //if (Input.GetKey(keyLeft))
            //{
            //    rig.velocity += speed * Vector2.left;
            //    toRight = false;
            //}
            //if (Input.GetKey(keyUp))
            //{
            //    rig.velocity += speed * Vector2.up;
            //}
            //if (Input.GetKey(keyDown))
            //{
            //    rig.velocity += speed * Vector2.down;
            //}

            //if (toRight && toRight != lastToRight)
            //{
            //    transform.localScale = new Vector3(1, 1, 1);
            //}
            //if (!toRight && toRight != lastToRight)
            //{
            //    transform.localScale = new Vector3(-1, 1, 1);
            //}
        }
        else
        {
            rig.velocity = Vector3.zero;
        }

        animator.SetFloat("Speed", rig.velocity.magnitude);
    }
}
