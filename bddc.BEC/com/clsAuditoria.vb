'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''
''  clsAuditoria.vb
''  Implementation of the Class clsAuditoria
''  Generated by Enterprise Architect
''  Created on:      06-ene-2011 03:27:33 p.m.
''  Original author: alejandro.borjas
''  
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''  Modification history:
''  
''
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



Option Explicit On
Option Strict On

Namespace COM
	Public MustInherit Class clsAuditoria


		Private intAudCreac_UsuarioId As Integer
		Private strAudCreac_Usuario As String
		Private datAudCreac_Fecha As Datetime
		Private intAudEdic_UsuarioId As Integer
		Private strAudEdic_Usuario As String
		Private datAudEdic_Fecha As Datetime
		''' <summary>
		''' Tabla bdauxiliar.tblaux_unidad -> cund_id
		''' </summary>
		Private intUnidadId As Integer

		Public Property AudCreac_UsuarioId() As Integer
			Get
				Return intAudCreac_UsuarioId
			End Get
			Set(ByVal Value as Integer)
				intAudCreac_UsuarioId = Value
			End Set
		End Property

		Public Property AudCreac_Fecha() As Datetime
			Get
				Return datAudCreac_Fecha
			End Get
			Set(ByVal Value as Datetime)
				datAudCreac_Fecha = Value
			End Set
		End Property

		Public Property AudEdic_UsuarioId() As Integer
			Get
				Return intAudEdic_UsuarioId
			End Get
			Set(ByVal Value as Integer)
				intAudEdic_UsuarioId = Value
			End Set
		End Property

		Public Property AudCreac_Usuario() As String
			Get
				Return strAudCreac_Usuario
			End Get
			Set(ByVal Value as String)
				strAudCreac_Usuario = Value
			End Set
		End Property

		Public Property AudEdic_Fecha() As Datetime
			Get
				Return datAudEdic_Fecha
			End Get
			Set(ByVal Value as Datetime)
				datAudEdic_Fecha = Value
			End Set
		End Property

		Public Property AudEdic_Usuario() As String
			Get
				Return strAudEdic_Usuario
			End Get
			Set(ByVal Value as String)
				strAudEdic_Usuario = Value
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


	End Class ' clsAuditoria

End Namespace ' COM