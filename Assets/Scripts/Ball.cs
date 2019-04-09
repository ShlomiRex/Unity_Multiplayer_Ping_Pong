using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    public Text txt_LeftScore = null;
    [SerializeField]
    public Text txt_RightScore = null;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float x_rand = Random.Range(0, 1);
        float y_rand = Random.Range(0, 1);

        rb.AddForce(new Vector2(Random.Range(-500, 500), Random.Range(-500, 500)));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        string name = other.gameObject.name;

        if (name == "Left Wall")
        {
            Debug.Log("Left Wall Collision");
            string txt = txt_RightScore.text;
            int i = System.Int32.Parse(txt);
            i++;
            txt_RightScore.text = "" + i;
        }
        if (name == "Right Wall")
        {
            Debug.Log("Right Wall Collision");
            string txt = txt_LeftScore.text;
            int i = System.Int32.Parse(txt);
            i++;
            txt_LeftScore.text = "" + i;
        }
    }
}
