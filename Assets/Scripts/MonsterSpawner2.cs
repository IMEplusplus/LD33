using UnityEngine;
using System.Collections;

public class MonsterSpawner2 : MonoBehaviour
{

    public GameObject elfPrefab;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            Instantiate(elfPrefab, transform.position + (Vector3.right) * 5, Quaternion.identity);
            Instantiate(elfPrefab, transform.position + (Vector3.left) * 5, Quaternion.identity);

            Destroy(this);
        }
    }
}
