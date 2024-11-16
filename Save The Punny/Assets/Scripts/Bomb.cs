using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float X_Rotate;
    public GameObject Dust;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, X_Rotate);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.Instance.GameOver();
            GameManager.Instance.GameOverSound.Play();
        }
        else if (collision.gameObject.tag == "Ground")
        {
            GameManager.Instance.IncrementScore();
            GameObject DestroyDust = Instantiate(Dust, transform.position, Quaternion.identity);
            Destroy(DestroyDust, 0.5f);
            Destroy(gameObject);
        }
    }
}
