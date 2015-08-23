using UnityEngine;

public class MonsterSpawner : MonoBehaviour {
    public GameObject elfPrefab;

    public Transform[] spawners;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            foreach(Transform spawn in spawners) {
                Instantiate(elfPrefab, spawn.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}
