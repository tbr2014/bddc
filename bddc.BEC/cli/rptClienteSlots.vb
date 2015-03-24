'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''
''  rptClienteSlots.vb
''  Implementation of the Class rptClienteSlots
''  Generated by Enterprise Architect
''  Created on:      03-nov-2010 05:16:55 p.m.
''  Original author: Alejandro Borjas
''  
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''  Modification history:
''  
''
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



Option Explicit On
Option Strict On

Imports bddc.BEC.CLI

Namespace CLI
	Public Class rptClienteSlots
		Inherits CLI.rptCliente


		Private intTier As Integer
		Private intRank As Integer
		Private decSlotWager As Decimal
		Private decSlotWon As Decimal
		Private decSlotPoints As Decimal

		Public Property Tier() As Integer
			Get
				Return intTier
			End Get
			Set(ByVal Value as Integer)
				intTier = Value
			End Set
		End Property

		Public Property Rank() As Integer
			Get
				Return intRank
			End Get
			Set(ByVal Value as Integer)
				intRank = Value
			End Set
		End Property

		Public Property SlotWager() As Decimal
			Get
				Return decSlotWager
			End Get
			Set(ByVal Value as Decimal)
				decSlotWager = Value
			End Set
		End Property

		Public Property SlotWon() As Decimal
			Get
				Return decSlotWon
			End Get
			Set(ByVal Value as Decimal)
				decSlotWon = Value
			End Set
		End Property

		Public Property SlotPoints() As Decimal
			Get
				Return decSlotPoints
			End Get
			Set(ByVal Value as Decimal)
				decSlotPoints = Value
			End Set
		End Property


	End Class ' rptClienteSlots

End Namespace ' CLI