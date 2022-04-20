using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDivFunction
{
    public class Class1
    {
        public static void Calculate()
        {
            string FunctionName = "LowLevelDivFunction";
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
                "Div",
                MethodAttributes.Public,
                typeof(int),
                new Type[] { typeof(int), typeof(int) }
                );

            var iLGenerator = methodBuilderCompare.GetILGenerator();

            iLGenerator.Emit(OpCodes.Ldarg_1);
            iLGenerator.Emit(OpCodes.Ldarg_2);
            iLGenerator.Emit(OpCodes.Div);// деление - Div
            iLGenerator.Emit(OpCodes.Ret);

            var ptType = typeBuilder.CreateType();

            builder.Save(assemblyName + ".dll");
        }
    }
}
