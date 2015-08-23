﻿using UnityEngine;
using System.Collections;

public class Elf : MonoBehaviour {
    public GameObject healthPotion;
    [Range(0f,1f)]
    public float potionDrop = 0.5f;

    void Awake() {
        GetComponent<HitPoint>().OnDeath = OnDeath;
    }

    void OnDeath() {
        GetComponent<BoxCollider2D>().enabled = false;
        StartCoroutine(OnDeathAnimation());
    }

    IEnumerator OnDeathAnimation() {
        yield return new WaitForSeconds(0.4f);
        GameObject.Find("ElfManager").GetComponent<ElfManagerController>().ManDown();
        if (Random.Range(0f, 1f) > potionDrop) {
            GameObject newPotion =(GameObject) Instantiate(healthPotion, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}