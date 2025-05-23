﻿

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CodeMonkey {

    /*
     * Global Asset references
     * Edit Asset references in the prefab CodeMonkey/Resources/CodeMonkeyAssets
     * */
    public class Assets : MonoBehaviour {

        // Internal instance reference
        private static Assets _i; 

        // Instance reference
        public static Assets i {
            get {
                if (_i == null) _i = Instantiate(Resources.Load<Assets>("CodeMonkeyAssets")); 
                return _i; 
            }
        }


        // All references
        
        public Sprite s_White;
        public Sprite s_Circle;

        public Material m_White;

    }

}
