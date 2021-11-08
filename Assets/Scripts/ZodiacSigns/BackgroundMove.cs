using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    private MeshRenderer mesh;
    public float speed;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        speed += 0.001f * Time.deltaTime;
        Vector2 offSet = new Vector2(0, speed * Time.time);
        mesh.sharedMaterial.SetTextureOffset("_MainTex", offSet);
    }
}
