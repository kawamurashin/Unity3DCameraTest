using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Library.Mizutama
{
    public class DebugWindow : MonoBehaviour
    {
        private static DebugWindow _instace;
        private static string _textToEdit = "TextField";
        private static List<string> _massages = new List<string>();

        private void OnGUI()
        {
            // テキストフィールドを表示する
            _textToEdit = GUI.TextArea(new Rect(10, 10, 500, 100), _textToEdit);
        }
        private DebugWindow()
        {

        }
        public static DebugWindow Instance
        {
            get
            {
                if (_instace != null) return _instace;
                var gameObject = new GameObject("DebugWindow");
                _instace = gameObject.AddComponent<DebugWindow>();
                return _instace;
            }
        }
        public static void Trace(string value)
        {
            _massages.Add(value);
            _massages = CheckListLenght(_massages);
            //
            var massage = "";
            var n = _massages.Count;
            for (var i = 0; i < n; i++)
            {
                massage = " [ " + DateTime.Now +" ]  " + _massages[i] + "\n" + massage;
            }

            _textToEdit = massage;
        }
        // Use this for initialization
        private void Start()
        {
            Debug.Log("[Mizutama DebugWindw Start]");
            //_massages = new List<string>();
            //Debug.Log();
        }

        // Update is called once per frame
        private void Update()
        {

        }
        //
        private static List<string> CheckListLenght(List<string> list)
        {
            if (list.Count <= 6) return list;
            list.RemoveAt(0);
            CheckListLenght(list);
            return list;
        }
    }


}
