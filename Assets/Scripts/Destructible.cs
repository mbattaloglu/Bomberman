using UnityEngine;

public class Destructible : MonoBehaviour
{
    public float destructionTime = 1f;

    [Header("Item Spawn Settings")]
    public GameObject[] items;
    [Range(0f, 1f)]
    public float itemSpawnChance = 0.2f;

    private void Start()
    {
        Destroy(gameObject, destructionTime);
    }

    private void OnDestroy()
    {
        if (Random.value < itemSpawnChance)
        {
            int index = Random.Range(0, items.Length);
            Instantiate(items[index], transform.position, Quaternion.identity);
        }
    }
}
