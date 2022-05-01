using System;

namespace App.Models.Abstractions
{
    public interface ILowLevelModel
    {
        int GetResultBitAnd(int a, int b);
        int GetResultDivUn(UInt32 a, UInt32 b);
        bool GetResultCompare(int a, int b);
    }
}