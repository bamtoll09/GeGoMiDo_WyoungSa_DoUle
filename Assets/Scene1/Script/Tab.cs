using UnityEngine;
using System.Collections;

public class Tab : MonoBehaviour {

    GameObject[] tabs = new GameObject[4];
    Collider2D[] colliders = new Collider2D[4];

	// Use this for initialization
	void Start () {
        for (int i=0; i<4; i++)
        {
            tabs[i] = transform.GetChild(i).gameObject;
        }

        colliders = GetComponents<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount != 0)
        {
            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                if (colliders[0] == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.touches[0].position)))
                {
                    setTabs(0);
                }
                else if (colliders[1] == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.touches[0].position)))
                {
                    setTabs(1);
                }
                else if (colliders[2] == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.touches[0].position)))
                {
                    setTabs(2);
                }
                else if (colliders[3] == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.touches[0].position)))
                {
                    setTabs(3);
                }
            }
        }
    }

    void setTabs(int num)
    {
        if (num == 0)
            tabs[0].SetActive(true);
        else
            tabs[0].SetActive(false);
        if (num == 1)
            tabs[1].SetActive(true);
        else
            tabs[1].SetActive(false);
        if (num == 2)
            tabs[2].SetActive(true);
        else
            tabs[2].SetActive(false);
        if (num == 3)
            tabs[3].SetActive(true);
        else
            tabs[3].SetActive(false);
    }
}
