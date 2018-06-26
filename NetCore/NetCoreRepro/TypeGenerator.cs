using System;
using System.Reflection;
using System.Reflection.Emit;

namespace NetCoreRepro
{
    public class TypeGenerator
    {
        private static readonly AssemblyBuilder AssemblyBuilder;
        private static readonly ModuleBuilder ModuleBuilder;
        private static readonly object Exclusive;

        static TypeGenerator()
        {
            AssemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("FooBar"), AssemblyBuilderAccess.Run);
            ModuleBuilder = AssemblyBuilder.DefineDynamicModule("FooBarModule");
            Exclusive = new object();
        }

        public static Type CreateClass(string name)
        {
            lock (Exclusive)
            {
                TypeBuilder typeBuilder = ModuleBuilder.DefineType(name);
                typeBuilder.DefineDefaultConstructor(MethodAttributes.Public);
                return typeBuilder.CreateTypeInfo().AsType();
            }
        }
    }
}