using HarmonyLib;
using System;
using UnityEngine;


namespace SignColorFix
{

	[HarmonyPatch(typeof(uGUI_SignInput), "UpdateScale")]
	class uGUI_SignInput_UpdateScale_Patch
	{
		[HarmonyPrefix]
		static bool Prefix(uGUI_SignInput __instance)
		{

			if (! __instance.gameObject.GetComponentInParent<Constructable>())
			{
				return false;
			}

			return true;
		}

	}

}
