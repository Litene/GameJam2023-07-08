using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreMangaer : MonoBehaviour {
    public TextMeshProUGUI _text;
    public Character _char;
    private void Update() {
        _text.text = _char.Size.ToString();
    }
}
