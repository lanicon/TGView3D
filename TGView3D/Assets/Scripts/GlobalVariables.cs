﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TGraph
{
    public static class GlobalVariables
    {
        public static ReadJSON.MyGraph Graph;
        public static bool Solved = false;
        public static int Vol;
        public static bool Init;
        public static bool Reload = false;
        public static UnityEngine.EventSystems.EventSystem EventSystem;
        public static bool JetPack = false;
        public static bool Beam = true;
        public static bool Recalculate = false;
        public static string Url = "";
        public static int SelectionIndex = 0;
        public static TextAsset CurrentFile;
        public static Text Percent;

        
    }
   

	
}
