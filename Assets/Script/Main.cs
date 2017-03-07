using Assets.Script.View;
using UnityEngine;

namespace Assets.Script
{
    public class Main : MonoBehaviour {

        // Use this for initialization
        private void Start () {
            var obj = new GameObject("hoge");
            ViewManager viewManager = obj.AddComponent<ViewManager>();

            obj = new GameObject("Camera");
            CamaraManager cameraManager = obj.AddComponent<CamaraManager>();


        }

        // Update is called once per frame
        private void Update () {

        }
    }
}
