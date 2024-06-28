using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IHasProgress
{
    public event EventHandler<OnprogressChangedArgs> OnProgressChanged;
    public class OnprogressChangedArgs : EventArgs
    {
        public float progressNormalized;
    }
}