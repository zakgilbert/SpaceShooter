using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private string HORIZONTAL = "Horizontal";
    private string VERTICAL = "Vertical";
    public Vector3 transformPosition (Vector3 vector) {
        transform.position = transform.position + vector * Time.deltaTime;
        return vector;
    }
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        transformPosition (new Vector3 (Input.GetAxis (HORIZONTAL), 0.0f, 0.0f));
        transformPosition (new Vector3 (0.0f, Input.GetAxis (VERTICAL), 0.0f));
    }
}