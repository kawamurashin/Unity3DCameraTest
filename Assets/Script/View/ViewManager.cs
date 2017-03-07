using UnityEngine;
namespace Assets.Script.View
{
    public class ViewManager: MonoBehaviour
    {
        private float d = 10;
        // Use this for initialization
        private void Start ()
        {
            Debug.Log("hoge");
            var n = 10;
            var m = 10;
            var l = 10;
            for (var k = 0; k < l; k++)
            {
                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j < m; j++)
                    {
                        var x = n * -0.5f * d + d * i;
                        var y = l*-0.5f*d + d*k;
                        var z = 10 + d * j;
                        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        obj.transform.parent = this.transform;
                        obj.transform.localPosition = new Vector3(x, y, z);

                    }
                }
            }

        }

        // Update is called once per frame
        private void Update () {

        }
    }
}