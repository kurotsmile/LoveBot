﻿#if UNITY_EDITOR
using UnityEditor;

namespace Crosstales.Radio.EditorTask
{
   /// <summary>Adds the given define symbols to PlayerSettings define symbols.</summary>
   [InitializeOnLoad]
   public class CompileDefines : Crosstales.Common.EditorTask.BaseCompileDefines
   {
      private static readonly string[] symbols = { "CT_RADIO" };

      static CompileDefines()
      {
         if (Crosstales.Radio.EditorUtil.EditorConfig.COMPILE_DEFINES)
         {
            addSymbolsToAllTargets(symbols);
         }
         else
         {
            removeSymbolsFromAllTargets(symbols);
         }
      }
   }
}
#endif
// © 2017-2024 crosstales LLC (https://www.crosstales.com)