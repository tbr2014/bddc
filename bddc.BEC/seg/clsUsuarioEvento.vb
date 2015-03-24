'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''
''  clsUsuarioEvento.vb
''  Implementation of the Class clsUsuarioEvento
''  Generated by Enterprise Architect
''  Created on:      06-ene-2011 03:40:52 p.m.
''  Original author: alejandro.borjas
''  
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''  Modification history:
''  
''
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



Option Explicit On
Option Strict On

Namespace SEG
	Public Class clsUsuarioEvento


		Private intUsuarioId As Integer
		Private strUsuarioNombre As String
		Private strUsuarioTerminal As String
		Private datEventoFecha As Datetime
		Private intEventoTipoId As Integer
		Private strEventoTipo As String
		Private strEventoAplicacion As String
		''' <summary>
		''' Tabla bdauxiliar.tblaux_unidad -> cund_id
		''' </summary>
		Private intUnidadId As Integer

		Public Property UsuarioId() As Integer
			Get
				Return intUsuarioId
			End Get
			Set(ByVal Value as Integer)
				intUsuarioId = Value
			End Set
		End Property

		Public Property UsuarioNombre() As String
			Get
				Return strUsuarioNombre
			End Get
			Set(ByVal Value as String)
				strUsuarioNombre = Value
			End Set
		End Property

		Public Property UsuarioTerminal() As String
			Get
				Return strUsuarioTerminal
			End Get
			Set(ByVal Value as String)
				strUsuarioTerminal = Value
			End Set
		End Property

		Public Property EventoFecha() As Datetime
			Get
				Return datEventoFecha
			End Get
			Set(ByVal Value as Datetime)
				datEventoFecha = Value
			End Set
		End Property

		Public Property EventoTipoId() As Integer
			Get
				Return intEventoTipoId
			End Get
			Set(ByVal Value as Integer)
				intEventoTipoId = Value
			End Set
		End Property

		Public Property EventoTipo() As String
			Get
				Return strEventoTipo
			End Get
			Set(ByVal Value as String)
				strEventoTipo = Value
			End Set
		End Property

		Public Property EventoAplicacion() As String
			Get
				Return strEventoAplicacion
			End Get
			Set(ByVal Value as String)
				strEventoAplicacion = Value
			End Set
		End Property

		''' <summary>
		''' Tabla bdauxiliar.tblaux_unidad -> cund_id
		''' </summary>
		Public Property UnidadId() As Integer
			Get
				Return intUnidadId
			End Get
			Set(ByVal Value as Integer)
				intUnidadId = Value
			End Set
		End Property


	End Class ' clsUsuarioEvento

End Namespace ' SEG