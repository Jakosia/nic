using UnityEngine;

public class abc
    : MonoBehaviour
{
    public Transform player;
    Vector3 vector = new Vector3(0f, 0.15f, -300f);

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        Vector3 newPosition = player.position + vector;
        transform.position = Vector3.Lerp(transform.position, newPosition, 0.05f);
    }
}
