using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    Collider2D collider;

	// Use this for initialization
	void Start () {
        collider = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "Item_Heal")
        {
            if (Input.touchCount != 0)
            {
                if (Input.touches[0].phase == TouchPhase.Ended && collider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.touches[0].position)))
                {
                    SoundManager.instance.Play("heal");
                }
            }
        }
    }
}
