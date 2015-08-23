using UnityEngine;

public class ElfMovement : MonoBehaviour {
    GameObject player;
    public Weapon weapon;
    HitPoint hitpoint;
    public float range;
    public float speed = 1f;
    public bool toRight = false;

    void Awake() {
        player = GameObject.Find("Player");
        hitpoint = GetComponent<HitPoint>();
    }

	void Update () {
        if (!weapon.isAttacking && hitpoint.alive) {
            Vector3 delta = player.transform.position - transform.position;
            if (delta.magnitude < range) {
                transform.position += delta.normalized * speed * Time.deltaTime;
                toRight = (delta.x > 0);
            }

            if (Mathf.Sign(delta.x) != Mathf.Sign(transform.localScale.x)) {
                Vector3 scale = transform.localScale;
                scale.x *= -1;
                transform.localScale = scale;
            }
        }
	}
}
