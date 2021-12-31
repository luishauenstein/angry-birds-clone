using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
   Vector2 _startPosition;

  // Start is called before the first frame update
  void Start()
    {
        _startPosition = GetComponent<Rigidbody2D>().position;
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    void OnMouseDown() {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseUp() {
        Vector2 currentPosition = GetComponent<Rigidbody2D>().position;
        Vector2 direction = _startPosition - currentPosition;
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    void OnMouseDrag() {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
