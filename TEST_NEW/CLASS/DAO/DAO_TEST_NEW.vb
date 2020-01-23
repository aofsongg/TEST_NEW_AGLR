Public Class DAO_TEST_NEW
    Public MustInherit Class MAINCONTEXT
        Public db As New LINQ_TEST_NEWDataContext
        Public datas

        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class

    Public Class TB_TABLE_USER
        Inherits MAINCONTEXT
        Public field As New TABLE_USER

        Public Sub insert()
            db.TABLE_USERs.InsertOnSubmit(field)
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.TABLE_USERs.DeleteOnSubmit(field)
            db.SubmitChanges()
        End Sub

        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub Get_Alldata()
            datas = (From q In db.TABLE_USERs Select q)

        End Sub

        Public Sub GET_PROFILE_BY_LOGIN(ByVal USER As String, ByVal PASS As String)
            datas = (From q In db.TABLE_USERs Where q.USERNAME = USER And q.PASSWORD = PASS Select q)
            For Each Me.field In datas

            Next
        End Sub


        Public Sub GET_USERNAE_BYUSER(ByVal USER As String)
            datas = (From q In db.TABLE_USERs Where q.USERNAME = USER Select q)
            For Each Me.field In datas
            Next
        End Sub


    End Class


End Class
