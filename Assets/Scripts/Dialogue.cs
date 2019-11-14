﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue  

{
    [System.Serializable]
    public class Info
    {
        public GameObject portrait;
        [TextArea(3, 10)]
        public string sentences;
    }
    
    public Info[] dialogueInfo;
}
