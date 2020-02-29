using UnityEngine;

public class Light : MonoBehaviour
{
    public Transform Player;
    Vector3 vector = new Vector3(0f, 0f, 0f);

    void Update()
    {
        LightMove();
    }

    void LightMove()
    {       
        transform.position = Player.position + vector;

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(new Vector3(mousePosition.x, mousePosition.y, transform.position.z));
    }
}
