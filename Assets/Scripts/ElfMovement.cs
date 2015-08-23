using UnityEngine;

public class ElfMovement : MonoBehaviour {
    GameObject player;
    public Weapon weapon;
    HitPoint hitpoint;
    Animator anim;

    public float range = 10f;
    public float speed = 1f;

    bool walking = false;

    void Awake() {
        player = GameObject.Find("Player");
        hitpoint = GetComponent<HitPoint>();
        anim = GetComponent<Animator>();
    }

	void Update () {
        if (!weapon.isAttacking && hitpoint.alive) {
            //walking = false;

            Vector3 delta = player.transform.position - transform.position;
            //if (delta.magnitude < range) {
                transform.position += delta.normalized * speed * Time.deltaTime;

                if (Mathf.Sign(transform.localScale.x) != Mathf.Sign(delta.x)) {
                    Vector3 scale = transform.localScale;
                    scale.x *= -1;
                    transform.localScale = scale;
                }

                walking = true;
            //}


            anim.SetBool("Walking", walking);
        }
	}
}
