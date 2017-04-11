using UnityEngine;
using System.Collections;

public class Tile_Script : MonoBehaviour {
	public GameObject X;
	public GameObject Y;
	public BoxCollider2D boxCollider2D;
	private bool placed = false;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1)
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (!placed && GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
			{
				Vector3 test = transform.TransformPoint (boxCollider2D.offset);
				test.z = 0;
				Instantiate(X, test, Quaternion.identity);

			}
		}
	}
}
