using UnityEngine;

public class ElfMovement : MonoBehaviour {
    GameObject player;
    public Weapon weapon;
    HitPoint hitpoint;
    Animator anim;

    public float range;
    public float speed = 1f;

    bool walking = false;

    void Awake() {
        player = GameObject.Find("Player");
        hitpoint = GetComponent<HitPoint>();
        anim = GetComponent<Animator>();
    }

	void Update () {
        walking = false;
        if (!weapon.isAttacking && hitpoint.alive) {
            Vector3 delta = player.transform.position - transform.position;
            if (delta.magnitude < range) {
                transform.position += delta.normalized * speed * Time.deltaTime;
                walking = true;
            }

            if (Mathf.Sign(delta.x) != Mathf.Sign(transform.localScale.x)) {
                Vector3 scale = transform.localScale;
                scale.x *= -1;
                transform.localScale = scale;
            }
        }

        anim.SetBool("Walking", walking);
	}
}
