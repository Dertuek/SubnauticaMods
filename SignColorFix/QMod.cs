using HarmonyLib;
using System;
using System.Reflection;

namespace SignColorFix
{
    public class QMod
    {
        public static void Patch()
        {
            try
            {
                var harmony = new Harmony("com.signcolorfix.mod");
                harmony.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception e)
            {
                Console.WriteLine($"SignColorFix patch failed!\n{FormatException(e)}");
            }
        }
        private static string FormatException(Exception e)
        {
            if (e == null)
                return string.Empty;
            return $"\"Exception: {e.GetType()}\"\n\tMessage: {e.Message}\n\tStacktrace: {e.StackTrace}\n" +
                   FormatException(e.InnerException);
        }
    }
}
