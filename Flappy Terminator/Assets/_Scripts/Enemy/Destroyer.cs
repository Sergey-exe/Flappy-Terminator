using UnityEngine;

public class Destroyer<T, K> : MonoBehaviour where T : Spawner<K> where K : MonoBehaviour
{
    [SerializeField] private T _spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        K objectK;

        if (objectK = collision.GetComponent<K>())
            _spawner.Release(objectK);
    }
}
