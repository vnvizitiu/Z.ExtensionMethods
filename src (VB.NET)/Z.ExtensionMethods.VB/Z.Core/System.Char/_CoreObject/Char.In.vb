
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_107

	''' <summary>
	'''     A T extension method to determines whether the object is equal to any of the provided values.
	''' </summary>
	''' <param name="this">The object to be compared.</param>
	''' <param name="values">The value list to compare with the object.</param>
	''' <returns>true if the values list contains the object, else false.</returns>
	''' ###
	''' <typeparam name="T">Generic type parameter.</typeparam>
	<System.Runtime.CompilerServices.Extension> _
	Public Function [In](this As [Char], ParamArray values As [Char]()) As Boolean
		Return Array.IndexOf(values, this) <> -1
	End Function
End Module


