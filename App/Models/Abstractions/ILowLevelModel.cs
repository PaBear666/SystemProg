using System;

namespace App.Controllers.Abstractions
{
    public interface ILowLevelModel
    {
        float GetResultDiv(float a, float b);
        int GetResultDivUn(UInt32 a, UInt32 b);
    }
}