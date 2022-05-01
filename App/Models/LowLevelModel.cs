using App.Models.Abstractions;
using LowLevelDivisionFunction;
using System;
using System.IO;
using System.Reflection;
namespace App.Models
{
    internal class LowLevelModel : ILowLevelModel
    {
        private object _instance;
        private MethodInfo _method;
        public LowLevelModel()
        {
            CompareFunction.Calculate();
            DivUnFunction.Calculate();      
            BitFunction.Calculate();
        }

        public int GetResultBitAnd(int a, int b)
        {
            string functionName = "BitFunction";
            string modName = functionName + ".dll";
            string typeName = functionName + "DLL";
            Assembly asm = Assembly.Load(File.ReadAllBytes(modName));
            Type t = asm.GetType(typeName);
            _method = t.GetMethod("And", BindingFlags.Instance | BindingFlags.Public);
            _instance = Activator.CreateInstance(t);
            return (int)_method.Invoke(_instance, new object[] { a, b });
        }

        public bool GetResultCompare(int a, int b)
        {
            string functionName = "CompareFunction";
            string modName = functionName + ".dll";
            string typeName = functionName + "DLL";
            Assembly asm = Assembly.Load(File.ReadAllBytes(modName));
            Type t = asm.GetType(typeName);
            _method = t.GetMethod("Ceq", BindingFlags.Instance | BindingFlags.Public);
            _instance = Activator.CreateInstance(t);
            return (int)_method.Invoke(_instance, new object[] { a, b }) == 1;
        }

        public int GetResultDivUn(UInt32 a, UInt32 b)
        {
            string functionName = "DivUnFunction";
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
