﻿using UnityEngine;
using UnityEngine.UI;

public static class MyColorExtensions
{

	public static Color WithAlphaSetTo(this Color color, float a)
	{
		return new Color(color.r, color.g, color.b, a);
	}

	public static void SetAlpha(this Image image, float a)
	{
		image.color = new Color(image.color.r, image.color.g, image.color.b, a);
	}

	public static void SetAlpha(this SpriteRenderer renderer, float a)
	{
		renderer.color = new Color(renderer.color.r, renderer.color.g, renderer.color.b, a);
	}

	public static string ToHex(this Color color)
	{
		return $"#{(int) (color.r * 255):X2}{(int) (color.g * 255):X2}{(int) (color.b * 255):X2}";
	}

}
