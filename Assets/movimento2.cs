using UnityEngine;

public class movimento2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        {
            Debug.LogError("Are you sure this is a Sprite?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.UpArrow)) direction.y = 1;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction.x = 1;
      
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction.x = -1;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) direction.y = -1;

        transform.position += direction;

        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f, 64);
        if (collision != null)
        {
            transform.position -= direction;

        }

    }
}
