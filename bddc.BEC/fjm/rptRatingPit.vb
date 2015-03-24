'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
''
''  rptRatingPit.vb
''  Implementation of the Class rptRatingPit
''  Generated by Enterprise Architect
''  Created on:      12-Jun-2010 11:30:12 a.m.
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
    Public Class rptRatingPit


        Private intPitId As Integer
        Private strPit As String
        Private intTipoJuegoId As Integer
        Private strTipoJuego As String
        Private strNroMesa As String
        Private strClienteCodigo As String
        Private strClienteNombreCompleto As String
        Private strFechaProceso As String
        Private decTotalDrop As Decimal
        Private decTotalWinLoss As Decimal

        Public Property PitId() As Integer
            Get
                Return intPitId
            End Get
            Set(ByVal Value As Integer)
                intPitId = Value
            End Set
        End Property

        Public Property Pit() As String
            Get
                Return strPit
            End Get
            Set(ByVal Value As String)
                strPit = Value
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

        Public Property NroMesa() As String
            Get
                Return strNroMesa
            End Get
            Set(ByVal Value As String)
                strNroMesa = Value
            End Set
        End Property

        Public Property ClienteCodigo() As String
            Get
                Return strClienteCodigo
            End Get
            Set(ByVal Value As String)
                strClienteCodigo = Value
            End Set
        End Property

        Public Property ClienteNombreCompleto() As String
            Get
                Return strClienteNombreCompleto
            End Get
            Set(ByVal Value As String)
                strClienteNombreCompleto = Value
            End Set
        End Property

        Public Property FechaProceso() As String
            Get
                Return strFechaProceso
            End Get
            Set(ByVal Value As String)
                strFechaProceso = Value
            End Set
        End Property

        Public Property TotalDrop() As Decimal
            Get
                Return decTotalDrop
            End Get
            Set(ByVal Value As Decimal)
                decTotalDrop = Value
            End Set
        End Property

        Public Property TotalWinLoss() As Decimal
            Get
                Return decTotalWinLoss
            End Get
            Set(ByVal Value As Decimal)
                decTotalWinLoss = Value
            End Set
        End Property


    End Class ' rptRatingPit

End Namespace ' CLI