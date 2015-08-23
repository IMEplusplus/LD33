using UnityEngine;
using System.Collections;

public class HealthPotion : MonoBehaviour {

    AudioSource audio;

    void Start()
    {
        GameObject Heal = GameObject.Find("Heal");
        audio = Heal.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col) {
        audio.Play();
        Destroy(this.gameObject);
        col.GetComponent<HitPoint>().Heal(5);
    }
}
