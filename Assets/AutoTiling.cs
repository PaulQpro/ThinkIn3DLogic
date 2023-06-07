using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class AutoTiling : MonoBehaviour
{
    public enum TilingType
    {
        XZ,
        XY,
        ZY
    }
    public TilingType type;
    public Material mat;
    public Vector2 offset;
    public float mult = 1;
    Transform tr;
    Material mat2;
    GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        go = tr.gameObject;
        mat2 = new Material(mat);
        go.GetComponent<Renderer>().material = mat2;
    }

    // Update is called once per frame
    void Update()
    {
        if (mat2 != null)
        {
            switch (type)
            {
                case TilingType.XZ:
                    mat2.mainTextureScale = new Vector2(go.transform.lossyScale.x / 2, go.transform.lossyScale.z / 2) * mult;
                    break;
                case TilingType.XY:
                    mat2.mainTextureScale = new Vector2(go.transform.lossyScale.x / 2, go.transform.lossyScale.y / 2) * mult;
                    break;
                case TilingType.ZY:
                    mat2.mainTextureScale = new Vector2(go.transform.lossyScale.z / 2, go.transform.lossyScale.y / 2) * mult;
                    break;
            }
            offset = new Vector2(offset.x % 1, offset.y % 1);
            mat2.mainTextureOffset = offset;
        }
    }
}
