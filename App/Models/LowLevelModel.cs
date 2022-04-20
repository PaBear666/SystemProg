using App.Controllers.Abstractions;
using LowLevelDivisionFunction;
using System;
using System.IO;
using System.Reflection;
namespace App.Controllers
{
    internal class LowLevelModel : ILowLevelModel
    {
        private object _instance;
        private MethodInfo _method;
        public LowLevelModel()
        {
            LowLevelDivFunction.Calculate();
            LowLevelDivUnFunction.Calculate();
        }

        public float GetResultDiv(float a, float b)
        {
            string functionName = "LowLevelDivFunction";
            string modName = functionName + ".dll";
            string typeName = functionName + "DLL";
            Assembly asm = Assembly.Load(File.ReadAllBytes(modName));
            Type t = asm.GetType(typeName);
            _method = t.GetMethod("Div", BindingFlags.Instance | BindingFlags.Public);
            _instance = Activator.CreateInstance(t);
            return (float)_method.Invoke(_instance, new object[] { a, b }); ;
        }
        public int GetResultDivUn(UInt32 a, UInt32 b)
        {
            string functionName = "LowLevelDivUnFunction";
            string modName = functionName + ".dll";
            string typeName = functionName + "DLL";
            Assembly asm = Assembly.Load(File.ReadAllBytes(modName));
            Type t = asm.GetType(typeName);
            _method = t.GetMethod("Div_Un", BindingFlags.Instance | BindingFlags.Public);
            _instance = Activator.CreateInstance(t);
            return (int)_method.Invoke(_instance, new object[] { a, b }); ;
        }
    }

}
