using System;
using System.Reflection;
using System.Reflection.Emit;

namespace LowLevelFunction
{
    class LowLevelCompareFunction
    {
        public static void Calculate()
        {
            string FunctionName = "LowLevelCompareFunction";
            string assemblyName = FunctionName;
            string modName = FunctionName + ".dll";
            string typeName = FunctionName + "DLL";

            AssemblyName name = new AssemblyName(assemblyName);
            AppDomain domain = System.Threading.Thread.GetDomain();
            AssemblyBuilder builder = domain.DefineDynamicAssembly(
              name, AssemblyBuilderAccess.RunAndSave);

            ModuleBuilder module = builder.DefineDynamicModule
              (modName, true);

            TypeBuilder typeBuilder = module.DefineType(typeName,
              TypeAttributes.Public);

            MethodBuilder methodBuilderCompare = typeBuilder.DefineMethod(
                "Compare",
                MethodAttributes.Public,
                typeof(int),
                new Type[] { typeof(int), typeof(int) }
                );

            var iLGenerator = methodBuilderCompare.GetILGenerator();

            iLGenerator.Emit(OpCodes.Ldarg_1);
            iLGenerator.Emit(OpCodes.Ldarg_2);
            iLGenerator.Emit(OpCodes.Cgt);
            iLGenerator.Emit(OpCodes.Ret);

            var ptType = typeBuilder.CreateType();

            builder.Save(assemblyName + ".dll");
        }
    }
}