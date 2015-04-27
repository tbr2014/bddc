Namespace Constante

    Public Module Sistema
        'Titulos:
        Public Const SISTIT As String = "Thunderbird Resorts - Soluciones IT Per�"
        Public Const SISLGI As String = "Log In"
        Public Const SISLGO As String = "Log Out"
        Public Const SISINI As String = "Bienvenidos"
        Public Const SISMIW As String = "P�gina en Construcci�n"

        'Modulos del Sistema:
        Public Const _MODTBL As String = "MODTBL"
        Public Const MODTBL As String = "M�dulo Auditor�a y Configuraci�n"
        Public Const _MODSEG As String = "MODSEG"
        Public Const MODSEG As String = "M�dulo Seguridad del Sistema"
        Public Const _MODFPC As String = "MODFPC"
        Public Const MODFPC As String = "M�dulo Fiesta Player's Club"
        Public Const _MODCYC As String = "MODCYC"
        Public Const MODCYC As String = "M�dulo Caja y Conteo"
        Public Const _MODGU As String = "MODGU"
        Public Const MODGU As String = "M�dulo Gesti�n de Usuario"

    End Module

    Public Module Mensajes
        'Sistema:
        'Public Msj_SistemaTitulo As String = "Fiesta Player's Club" 'Debe ser cambiado! (06/12/2010)
        'Public Msj_SistemaTitulo As String = "Acceso al sistema" 'Debe ser cambiado! (06/12/2010)
        Public Msj_SistemaTitulo As String = "Multicasino Fiesta Player's CLub"

        'Resultados de Operaciones:
        Public Ope_BuscarOK As String = "B�squeda exitosa"
        Public Ope_BuscarNONE As String = "No se encontr� informaci�n"
        Public Ope_BuscarERR As String = "Error en la b�squeda. Revisar!"
        Public Ope_BuscarNUMREG As String = "Total: XX registro(s)"
        Public Ope_BuscarSinParametros As String = "Faltan datos v�lidos para la b�squeda. Revisar!"
        Public Ope_LeerOK As String = "Lectura exitosa"
        Public Ope_LeerERR As String = "Lectura sin �xito"
        Public Ope_CrearOK As String = "Se cre� el Registro con �xito"
        Public Ope_CrearERR As String = "No se cre� el Registro"
        Public Ope_ActualizarOK As String = "Se actualiz� el Registro con �xito"
        Public Ope_ActualizarERR As String = "No se actualiz� el Registro"
        Public Ope_ActualizarGridOK As String = "Se actualizaron todos datos!"
        Public Ope_ActualizarGridERR As String = "No se actualizaron datos!"
        Public Ope_EscribirOK As String = "Se guard� el Registro con �xito"
        Public Ope_EscribirERR As String = "No se guard� el Registro"
        Public Ope_EscribirREP As String = "Ya existe Registro!"
        Public Ope_EliminarOK As String = "Se elimin� el Registro con �xito"
        Public Ope_EliminarERR As String = "No se elimin� el Registro"
        Public Ope_PublicarOK As String = "Se public� con �xito"
        Public Ope_PublicarERR As String = "No se public�"
        Public Ope_PublicarVER As String = "Verificar publicaci�n!"
        Public Ope_PublicarMensaje As String = "Publicaci�n de Formulario No. XXX: YYY"
        Public Ope_SolicitudCodigoGenerado As String = "Solicitud No. XXX: Ok!"
        Public Oper_ConfiguraEstilos As String = "Problemas al configurar Estilos de Controles"
        Public Ope_OperacionOK As String = "Operaci�n exitosa!"
        Public Ope_OperacionERR As String = "Operaci�n sin �xito!"
        Public Ope_ProcesoInicio As String = "Iniciando proceso..."
        Public Ope_EnProceso As String = "En proceso..."
        Public Ope_ProcesoFin As String = "Proceso finalizado!"
        Public Ope_ProcesoInvalido As String = "No se puede procesar al mismo usuario. Revisar."
        Public Ope_ExportarReporte As String = "Se exporto exisitosamente el archivo!"
        Public Ope_InactivarUsuarioOk As String = "Se ha inactivado el usuario con �xito."
        Public Ope_InactivarUsuarioERR As String = "No se ha inactivado el usuario."

        'Mensajes de Accesos:
        Public Acc_AutenticacionOK As String = "Autenticaci�n exitosa!"
        Public Acc_AutenticacionERR As String = "Usuario y/o clave incorrecto(s)"
        Public Acc_UsuarioERR As String = "Usuario no existe en el sistema!"
        Public Acc_AutorizacionOK As String = "Usuario autorizado!"
        Public Acc_AutorizacionERR As String = "Acceso no autorizado al usuario!"
        Public Acc_SesionOK As String = "Configurando accesos del usuario!"
        Public Acc_SesionERR As String = "Usuario sin configuraci�n de acceso"
        Public Acc_LecturaERR As String = "Problemas en la lectura de datos del Usuario"
        Public Acc_ConfigERR As String = "No hay datos de Configuraci�n de la Aplicaci�n"
        Public Acc_LanguageERR As String = "Error al leer Lenguaje de la Aplicaci�n"


        'Mensajes de B�squedas:
        Public Msj_SinEspeficar As String = "Ingrese N�mero de Documento"
        Public Msj_SinDatos As String = "Faltan datos para guardar!"
        Public Msj_LimiteRegistros As String = "Mostrando XX �ltimos registros!"
        Public Msj_DatoInvalido As String = "Ingresando dato inv�lido!"
        Public Msj_UsuarioEditando As String = "Hay un usuario editando datos!"

        'Mensajes de Impresi�n:
        Public Msj_ImpresoraPredeterminadaERR As String = "Impresora predeterminada incorrecta!"
        Public Msj_ImpresoraEstadoERR As String = "Problemas para realizar la impresi�n!"
        Public Msj_ImpresoraInstaladaERR As String = "La impresora no instalada en esta terminal!"
        Public Msj_ImpresoraDimensionPaginaERR As String = "Dimensi�n P�gina (recomendada): "

        'Resultados de Exportacion:
        Public Res_ExportacionOK As String = "Archivo Generado"
        Public Res_ExportacionERR As String = "Archivo No Generado!"
        Public Res_ExportacionNO As String = "Datos Incorrectos para la Exportaci�n!"

        'Aprobaci�n de Solicitud
        Public Solicitud_AprobacionOK As String = "Aprobado"
        Public Solicitud_AprobacionNO As String = "Sin Aprobaci�n"
        Public Solicitud_AprobacionPor As String = "- Aprobado por -"
        Public Solicitud_SinCodigo As String = "Ingrese c�digo de Solicitud!"
        Public Solicitud_ValidacionERR As String = "Datos de la solicitud incorrectos y/o faltan ingresar!"

        'Items comunes para listas
        Public Opcion_Seleccione As String = "- Seleccione -"
        Public Opcion_Todos As String = "- Todos -"
        Public Opcion_Ninguno As String = "- Ninguno -"
        Public Opcion_SinEspecificar As String = "- Sin Especificar -"
        Public Opcion_AsignacionAutomatica As String = "- Asignaci�n Autom�tica -"

        'Puntos Reward de Contactos
        Public PtoReward_Promocion As String = "V�lido del <Fecha1> al <Fecha2>"

        'Cotizador de Eventos Online
        Public CEO_EspecificarTipoEvento As String = "Seleccionar tipo de Evento"
        Public CEO_EspecificarNumPersonas As String = "Indicar n�mero de personas"
        Public CEO_EspecificarDuracion As String = "Indicar duraci�n del evento"
        Public CEO_InputTexto As String = "Ingresar n�mero"
        Public CEO_InputCheck As String = "Seleccionar"


        Public CEO_TipoEvento_Alojamiento As String = "Alojamiento"
        Public CEO_TipoEvento_AlojamientoAllInclusive As String = "Alojamiento AllInclusive"
        Public CEO_TipoEvento_AlojamientoRegular As String = "Alojamiento Regular"
        Public CEO_TipoEvento_EventoAmbiente As String = "Ambiente del Evento"
        Public CEO_TipoEvento_EventoDistribSillas As String = "Evento - Distribuci�n de Sala"
        Public CEO_TipoEvento_EventoAdicionales As String = "Evento - Protocolo de Sala"
        Public CEO_TipoEvento_Entretenimiento As String = "Evento - Entretenimiento"
        Public CEO_TipoEvento_Matrimonio As String = "Matrimonio"
        Public CEO_TipoEvento_AlimentosyBebidas As String = "Alimentos y Bebidas"

        'FCB ThunderPits Mesas
        Public FCB_ProcesoCierre_OK As String = "Cierre exitoso."
        Public FCB_ProcesoCierre_NO As String = "Cierre pendiente. Aplicar!"
        Public FCB_ImprimirTicket_NONE As String = "No hay Ticket(s) para imprimir!"
        Public FCB_ImprimirTicket_ERR As String = "No se pueden leer datos del Cliente!"
        Public FCB_FechaProceso_ERR As String = "Sin Fecha de Proceso!"
        Public FCB_HoraProceso_ERR As String = "No est� dentro de Turno del d�a!  (XX Hr. - YY Hr.)."
        Public FCB_TipoOperacion_Apertura As String = "Apertura"

        'Mensaje de confirmacion
        Public Msg_ConfAgregar As String = "Esta seguro que desea guardar el registro?"
        Public Msg_ConfEliminar As String = "Esta seguro que desea eliminar el registro?"
        Public Msg_ConfInactivar As String = "Esta seguro que quiere inactivar el usuario?"

        'Mensaje Validacion
        Public Msg_ClienteNoSeleccionado As String = "Error: Debe seleccionar al menos un cliente."

        'Ubigeo
        Public CONST_PROV_LIMA As Integer = 133 'Por default: Provincia de Lima

    End Module

    Public Module DiccionarioDatos

        Public CONST_CODIGO_CORTO_2 As Integer = 2
        Public CONST_CODIGO_CORTO_6 As Integer = 6
        Public CONST_CODIGO_MEDIO_10 As Integer = 10
        Public CONST_CODIGO_LARGO_20 As Integer = 20
        Public CONST_NOMBRE_50 As Integer = 50
        Public CONST_DESCRIPCION_100 As Integer = 100
        Public CONST_COMENTARIO_CORTO_200 As Integer = 200
        Public CONST_COMENTARIO_LARGO_500 As Integer = 500
        Public CONST_DOCUMENTO_5000 As Integer = 5000
        Public CONST_DOCUMENTO_Largo_65535 As Integer = 65535

    End Module
End Namespace

