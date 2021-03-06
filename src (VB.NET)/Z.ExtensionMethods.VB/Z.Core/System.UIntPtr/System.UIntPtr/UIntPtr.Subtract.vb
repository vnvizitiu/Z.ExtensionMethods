
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_632

	''' <summary>
	'''     Subtracts an offset from the value of an unsigned pointer.
	''' </summary>
	''' <param name="pointer">The unsigned pointer to subtract the offset from.</param>
	''' <param name="offset">The offset to subtract.</param>
	''' <returns>A new unsigned pointer that reflects the subtraction of  from .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Subtract(pointer As UIntPtr, offset As Int32) As UIntPtr
		Return UIntPtr.Subtract(pointer, offset)
	End Function
End Module


