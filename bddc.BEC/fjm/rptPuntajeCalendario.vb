'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''
''  rptPuntajeCalendario.vb
''  Implementation of the Class rptPuntajeCalendario
''  Generated by Enterprise Architect
''  Created on:      10-Ago-2010 01:02:20 p.m.
''  Original author: alejandro.borjas
''  
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''  Modification history:
''  
''
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



Option Explicit On
Option Strict On

Namespace FJM
    Public Class rptPuntajeCalendario


        Private intProcesoA�o As Integer
        Private intProcesoMes As Integer
        Private intProcesoDia As Integer
        Private strClienteCodigo As String
        Private strClienteApellidos As String
        Private strClienteNombres As String
        Private intTipoJuegoId As Integer
        Private strTipoJuego As String
        Private decWinTeorico As Decimal
        Private intNumCupones As Integer

        Public Property ProcesoA�o() As Integer
            Get
                Return intProcesoA�o
            End Get
            Set(ByVal Value As Integer)
                intProcesoA�o = Value
            End Set
        End Property

        Public Property ProcesoMes() As Integer
            Get
                Return intProcesoMes
            End Get
            Set(ByVal Value As Integer)
                intProcesoMes = Value
            End Set
        End Property

        Public Property ProcesoDia() As Integer
            Get
                Return intProcesoDia
            End Get
            Set(ByVal Value As Integer)
                intProcesoDia = Value
            End Set
        End Property

        Public ReadOnly Property ClienteNombreCompleto() As String
            Get
                Return strClienteApellidos & ", " & ClienteNombres
            End Get
        End Property

        Public Property ClienteCodigo() As String
            Get
                Return strClienteCodigo
            End Get
            Set(ByVal Value As String)
                strClienteCodigo = Value
            End Set
        End Property

        Public Property ClienteApellidos() As String
            Get
                Return strClienteApellidos
            End Get
            Set(ByVal Value As String)
                strClienteApellidos = Value
            End Set
        End Property

        Public Property ClienteNombres() As String
            Get
                Return strClienteNombres
            End Get
            Set(ByVal Value As String)
                strClienteNombres = Value
            End Set
        End Property

        Public Property TipoJuegoId() As Integer
            Get
                Return intTipoJuegoId
            End Get
            Set(ByVal Value As Integer)
                intTipoJuegoId = Value
            End Set
        End Property

        Public Property TipoJuego() As String
            Get
                Return strTipoJuego
            End Get
            Set(ByVal Value As String)
                strTipoJuego = Value
            End Set
        End Property

        Public Property WinTeorico() As Decimal
            Get
                Return decWinTeorico
            End Get
            Set(ByVal Value As Decimal)
                decWinTeorico = Value
            End Set
        End Property

        Public Property NumCupones() As Integer
            Get
                Return intNumCupones
            End Get
            Set(ByVal Value As Integer)
                intNumCupones = Value
            End Set
        End Property


    End Class ' rptPuntajeCalendario

End Namespace ' CLI