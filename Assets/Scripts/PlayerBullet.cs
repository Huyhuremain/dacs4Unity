using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 22f;
    [SerializeField] private float timeDestroy = 0.5f;
    void Start()
    {
        Destroy(gameObject, timeDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        moveBullet();
    }
    void moveBullet()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}
