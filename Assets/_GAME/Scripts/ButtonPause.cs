using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : UICanvas
{
    // Start is called before the first frame update
    public void MainMenuButton()
    {
        UIManager.Ins.OpenUI<UIPause>();
        Close(0);
    }
}
