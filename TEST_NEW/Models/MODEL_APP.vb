Public Class MODEL_APP

    Private _FUNC_CODE As String
    Public Property FUNC_CODE() As String
        Get
            Return _FUNC_CODE
        End Get
        Set(ByVal value As String)
            _FUNC_CODE = value
        End Set
    End Property

    Private _DETAIL_DATA As New Object
    Public Property DETAIL_DATA() As Object
        Get
            Return _DETAIL_DATA
        End Get
        Set(ByVal value As Object)
            _DETAIL_DATA = value
        End Set
    End Property


    Private _CLS_TABLE_USER As New TABLE_USER
    Public Property CLS_TABLE_USER() As TABLE_USER
        Get
            Return _CLS_TABLE_USER
        End Get
        Set(ByVal value As TABLE_USER)
            _CLS_TABLE_USER = value
        End Set
    End Property

    Private _CLS_TABLE_USER_LIST As New List(Of TABLE_USER)
    Public Property CLS_TABLE_USER_LIST() As List(Of TABLE_USER)
        Get
            Return _CLS_TABLE_USER_LIST
        End Get
        Set(ByVal value As List(Of TABLE_USER))
            _CLS_TABLE_USER_LIST = value
        End Set
    End Property

    Private _USERNAME As String
    Public Property USERNAME() As String
        Get
            Return _USERNAME
        End Get
        Set(ByVal value As String)
            _USERNAME = value
        End Set
    End Property

    Private _PASSWORD As String
    Public Property PASSWORD() As String
        Get
            Return _PASSWORD
        End Get
        Set(ByVal value As String)
            _PASSWORD = value
        End Set
    End Property

    Private _RESULT_STR As String
    Public Property RESULT_STR() As String
        Get
            Return _RESULT_STR
        End Get
        Set(ByVal value As String)
            _RESULT_STR = value
        End Set
    End Property

    Private _RESULT_FUNC As New Object
    Public Property RESULT_FUNC() As Object
        Get
            Return _RESULT_FUNC
        End Get
        Set(ByVal value As Object)
            _RESULT_FUNC = value
        End Set
    End Property

    Private _RESULT_FUNC_LIST As New Object
    Public Property RESULT_FUNC_LIST() As Object
        Get
            Return _RESULT_FUNC_LIST
        End Get
        Set(ByVal value As Object)
            _RESULT_FUNC_LIST = value
        End Set
    End Property



End Class
