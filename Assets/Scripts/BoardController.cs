using UnityEngine;
using System.Collections;

public class BoardController : MonoBehaviour
{

    public Transform BoardImage;
    public Transform Marker;
	// Use this for initialization
	void Start ()
	{
	    var size = new Vector3(6.9f,6.9f);
	    var offset = new Vector2(0.5f, 0.5f);
	    var topCorner = new Vector3(-size.x*0.5f + offset.x, size.y*0.5f - offset.y,0);

	    Marker.transform.position = GridToWorld(new Vector2(6,6),topCorner,size);
	    //var this.renderer.bounds.size.x;
	}

    private Vector3 GridToWorld(Vector2 grid, Vector3 leftCorner, Vector3 size)
    {

        var result = new Vector3(grid.x*size.x/10f, grid.y*size.y/10f, -1);
        result = new Vector3(result.x + leftCorner.x, -result.y + leftCorner.y,-1);
        return result;
    }
    private Vector3 GetScreenSize(Bounds bounds)
    {
        return Camera.main.WorldToScreenPoint(bounds.size);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
