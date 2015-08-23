using UnityEngine;
using System.Collections;

public class HealthPotion : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col) {
        Destroy(this.gameObject);
        col.GetComponent<HitPoint>().Heal(5);
    }
}
