using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book_click : MonoBehaviour
{

    public GameObject book_info;
    public Transform book_info_pos;
    public GameObject speaker_book;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        book_info.transform.position = new Vector3(book_info_pos.transform.position.x, book_info_pos.transform.position.y, book_info_pos.transform.position.z);
        Instantiate(book_info);
        Destroy(gameObject, 1);
        speaker_book.SetActive(true);
    }
}
