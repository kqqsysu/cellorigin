﻿// Generated by github.com/davyxu/cellorigin
using UnityEngine;
using UnityEngine.UI;
using System;


partial class TestBoardPresenter : Framework.BasePresenter
{    
    Framework.IProperty _TextInfo;
	
	public void Init( )
	{
        
        _TextInfo = GetProperty("TextInfo");
        

        var mdm = Framework.ModelDataManager.Instance;

        mdm.Register<Framework.IntegerModel>("Coin");

        mdm.Listen("Coin", (msb) =>
        {
            _TextInfo.SetValue(mdm.GetValueAsString("Coin"));
        });

        _TextInfo.SetValue(mdm.GetValueAsString("Coin"));


        
	}
	
}
